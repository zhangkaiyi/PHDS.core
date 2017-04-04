using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.QY.Containers;
using Senparc.Weixin.QY.CommonAPIs;
using Senparc.Weixin.QY.AdvancedAPIs;
using Microsoft.Extensions.Options;
using PHDS.core.Utility;
using PHDS.core.Entities.Pinhua;
using Microsoft.AspNetCore.Http;
using Senparc.Weixin.Exceptions;
using Newtonsoft.Json;
using Senparc.Weixin.HttpUtility;
using Senparc.Weixin.QY.AdvancedAPIs.MailList;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using PHDS.core.Entities;

namespace PHDS.core.Controllers
{
    public class WxClockController : Controller
    {
        public WeixinOptions wxOptions;
        public WeixinClockOptions clockOptions;
        public PinhuaContext pinhuaContext;

        public WxClockController(Entities.Pinhua.PinhuaContext pinhuaContext)
        {
            this.pinhuaContext = pinhuaContext;
            this.wxOptions = pinhuaContext.WeixinOptions.FirstOrDefault();
            this.clockOptions = pinhuaContext.WeixinClockOptions.FirstOrDefault();
        }

        public IActionResult OAuth(string code, string state, string returnUrl)
        {
            if (string.IsNullOrEmpty(code))
            {
                ViewData["Message"] = "code值为空";
                return View();
            }

            var tokenResult = CommonApi.GetToken(wxOptions.CorpId, wxOptions.Secret);

            if (!(tokenResult.errcode == Senparc.Weixin.ReturnCode_QY.请求成功))
            {
                ViewData["Message"] = JsonConvert.SerializeObject(tokenResult);
                return View();
            }

            var userinfoResult = OAuth2Api.GetUserId(tokenResult.access_token, code);

            if (!(userinfoResult.errcode == Senparc.Weixin.ReturnCode_QY.请求成功))
            {
                ViewData["Message"] = JsonConvert.SerializeObject(userinfoResult);
                return View();
            }

            if (string.IsNullOrEmpty(userinfoResult.UserId))
            {
                ViewData["Message"] = "非企业人员，考勤功能不可用！";
                return View();
            }

            var memberResult = MailListApi.GetMember(tokenResult.access_token, userinfoResult.UserId);
            if (memberResult.errcode == Senparc.Weixin.ReturnCode_QY.请求成功)
            {
                if (string.IsNullOrEmpty(returnUrl))
                    return View();
                else
                {
                    var memberString = JsonConvert.SerializeObject(memberResult);
                    var memberParam = $"?member={memberString.UrlEncode()}";
                    return Redirect(returnUrl + memberParam);
                }
            }

            return View();
        }

        public IActionResult Index(string member)
        {
            if (string.IsNullOrEmpty(member))
            {
                ViewData["Message"] = "人员信息不存在！";
                return View();
            }
            var memberJson = member.UrlDecode();
            var memberResult = JsonConvert.DeserializeObject<GetMemberResult>(memberJson);
            if (string.IsNullOrEmpty(memberResult.userid))
            {
                ViewData["Message"] = "人员信息无效！";
                return View();
            }

            HttpContext.Session.SetObjectAsJson("memberResult", memberResult);
            return View(memberResult);
        }

        public IActionResult ClockIn(GetMemberResult member)
        {
            var b = CheckClockIn(member, ClockType.签到, out var errors);
            if (b)
                if (!InsertWeixinClock(ClockType.签到, member))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }
        public IActionResult ClockOut(GetMemberResult member)
        {
            var b = CheckClockOut(member, ClockType.签退, out var errors);
            if (b)
                if (!InsertWeixinClock(ClockType.签退, member))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }

        public IActionResult Tab2()
        {
            var memberResult = HttpContext.Session.GetObjectFromJson<GetMemberResult>("memberResult");
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(wxOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex","STATE"));

            return View(memberResult);
        }

        public IActionResult Tab3()
        {
            var memberResult = HttpContext.Session.GetObjectFromJson<GetMemberResult>("memberResult");
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(wxOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            return View(memberResult);
        }

        public IActionResult Tab4()
        {
            var memberResult = HttpContext.Session.GetObjectFromJson<GetMemberResult>("memberResult");
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(wxOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            ViewData[nameof(GetDepartmentListResult)] = GetDepartmentList();

            return View(memberResult);
        }

        public IActionResult AjaxGetClockResult(string userid, string date)
        {
            var targetDate = DateTime.Parse(date);

            var results = new List<ComputedClockResult>();
            var ranges = pinhuaContext.GetCurrentClockRanges();
            ranges.ForEach(p=> {
                results.Add(new ComputedClockResult
                {
                    RangeId = p.Id,
                    RangeName = p.Name,
                    ClockInTime = null,
                    ClockInResult = ClockResultEnum.无记录,
                    ClockOutTime = null,
                    ClockOutResult = ClockResultEnum.无记录,
                    RangeString = p.指定日期的工作时间区间转文字(targetDate),
                });
            });
            

            var clocks = pinhuaContext.GetTargetDateClockRecords(targetDate, userid).OrderBy(p => p.Clocktime);

            foreach (var range in ranges.OrderBy(p => p.Id))
            {
                foreach(var clock in clocks)
                {
                    if(clock.Clocktype == (int)ClockType.签到)
                    {
                        range.指定日期的签到区间(targetDate, out var begin, out var end);
                        if (clock.Clocktime.Value.IsBetween(begin, end))
                        {
                            range.指定日期的工作时间区间(targetDate, out var a, out var b);
                            var t = clock.Clocktime.Value.Subtract(b);
                            results.ForEach(p =>
                            {
                                if (p.RangeId == range.Id)
                                {
                                    p.ClockInTime = clock.Clocktime;
                                    p.ClockInResult = t.Ticks > 0 ? ClockResultEnum.迟到 : ClockResultEnum.正常;
                                }
                            });
                        }
                    }
                    if(clock.Clocktype == (int)ClockType.签退)
                    {
                        range.指定日期的签退区间(targetDate, out var begin, out var end);
                        if (clock.Clocktime.Value.IsBetween(begin, end))
                        {
                            range.指定日期的工作时间区间(targetDate, out var a, out var b);
                            var t = clock.Clocktime.Value.Subtract(b);
                            results.ForEach(p =>
                            {
                                if (p.RangeId == range.Id)
                                {
                                    p.ClockOutTime = clock.Clocktime;
                                    p.ClockOutResult = t.Ticks < 0 ? ClockResultEnum.早退 : ClockResultEnum.正常;
                                }
                            });
                        }
                    }
                }
            }

            return Json(results);
        }

        public IActionResult Error()
        {
            return View();
        }

        private bool CheckClockIn(GetMemberResult member, ClockType type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();
            var sType = "签到";

            if (pinhuaContext.WeixinClockOptions.FirstOrDefault().Ip != HttpContext.Connection.RemoteIpAddress.ToString())
            {
                errors.Add("非公司网络");
                b = false;
            }

            var planDetail = pinhuaContext.GetCurrentClockRange();
            if (planDetail == null)
            {
                errors.Add("非工作时段");
                b = false;
            }
            else
            {
                planDetail.今天的签到区间(out var t1, out var t2);
                if (!DateTime.Now.IsBetween(t1, t2))
                {
                    errors.Add($"{planDetail.Name}的{sType}时间是 {t1.ToShortTimeString()}～{t2.ToShortTimeString()}");
                    b = false;
                }
                var r = from p in pinhuaContext.WeixinClock
                        where p.Userid == member.userid && p.Clocktime.Value.IsBetween(t1, t2) && p.Clocktype == (int)ClockType.签到
                        select p;
                if (r.Count() > 0)
                {
                    errors.Add($"当前班段 {r.FirstOrDefault().Clocktime.Value.ToShortTimeString()} 已经有过{sType}记录，请勿重复打卡！");
                    b = false;
                }

            }

            return b;
        }

        private bool CheckClockOut(GetMemberResult member, ClockType type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();
            var sType = "签退";

            if (pinhuaContext.WeixinClockOptions.FirstOrDefault().Ip != HttpContext.Connection.RemoteIpAddress.ToString())
            {
                errors.Add("非公司网络");
                b = false;
            }

            var planDetail = pinhuaContext.GetCurrentClockRange();
            if (planDetail == null)
            {
                errors.Add("非工作时段");
                b = false;
            }
            else
            {
                planDetail.今天的签退区间(out var t1, out var t2);
                if (!DateTime.Now.IsBetween(t1, t2))
                {
                    errors.Add($"{planDetail.Name}的{sType}时间是 {t1.ToShortTimeString()}～{t2.ToShortTimeString()}");
                    b = false;
                }
                var r = from p in pinhuaContext.WeixinClock
                        where member.userid == p.Userid && p.Clocktime.Value.IsBetween(t1, t2) && p.Clocktype == (int)ClockType.签退
                        select p;
                if (r.Count() > 0)
                {
                    errors.Add($"当前班段 {r.FirstOrDefault().Clocktime.Value.ToShortTimeString()} 已经有过{sType}记录，请勿重复打卡！");
                    b = false;
                }
            }

            return b;
        }

        private bool InsertWeixinClock(ClockType type, GetMemberResult member)
        {
            var rtId = "144.1";

            var rcId = pinhuaContext.GetNewRcId();

            var repCase = new EsRepCase
            {
                RcId = rcId,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = member.name,
                LstFillDate = DateTime.Now,
                FillDate = DateTime.Now,
            };

            var record = new WeixinClock
            {
                ExcelServerRtid = rtId,
                ExcelServerRcid = rcId,
                ClockPlanId = pinhuaContext.GetCurrentClockRange().ExcelServerRcid,
                Clocktype = (int?)type,
                Weixinid = member.weixinid,
                Userid = member.userid,
                Name = member.name,
                Clocktime = DateTime.Now,
            };

            pinhuaContext.EsRepCase.Add(repCase);
            pinhuaContext.WeixinClock.Add(record);

            var b = pinhuaContext.SaveChanges();
            if (b > 0)
                return true;
            else
                return false;
        }

        private GetDepartmentListResult GetDepartmentList()
        {
            var tokenResult = CommonApi.GetToken(wxOptions.CorpId, wxOptions.Secret);
            return MailListApi.GetDepartmentList(tokenResult.access_token);
        }

        public IActionResult Top10()
        {
            return View();
        }

        public IActionResult Declaration()
        {
            return View();
        }
    }
    public enum ClockType
    {
        签退,
        签到
    }
}

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
    public class WxClockController : AController
    {
        public WxClockController(PinhuaContext pinhuaContext) : base(pinhuaContext)
        {
        }

        public IActionResult OAuth(string code, string state, string returnUrl)
        {
            if (string.IsNullOrEmpty(code))
            {
                ViewData["Message"] = "code值为空";
                return View();
            }

            var tokenResult = CommonApi.GetToken(WeixinOptions.CorpId, WeixinOptions.Secret);

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
                    AppSessions.SetMember(memberResult);
                    return RedirectToAction(nameof(Index));
                }
            }

            return View();
        }

        public IActionResult Index(string member)
        {
            var memberResult = new GetMemberResult();

            if (!string.IsNullOrEmpty(member))
            {
                var memberJson = member.UrlDecode();
                memberResult = JsonConvert.DeserializeObject<GetMemberResult>(memberJson);
            }
            else
            {
                memberResult = AppSessions.GetMember();
                if (memberResult == null)
                {
                    ViewData["Message"] = "人员信息不存在！";
                    return View();
                }
            }
            
            if (string.IsNullOrEmpty(memberResult.userid))
            {
                ViewData["Message"] = "人员信息无效！";
                return View();
            }

            AppSessions.SetMember(memberResult);
            return View(memberResult);
        }

        public IActionResult ClockIn(GetMemberResult member)
        {
            var b = CheckClockIn(member, Enum打卡类型.签到, out var errors);
            if (b)
                if (!InsertWeixinClock(Enum打卡类型.签到, member))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }
        public IActionResult ClockOut(GetMemberResult member)
        {
            var b = CheckClockOut(member, Enum打卡类型.签退, out var errors);
            if (b)
                if (!InsertWeixinClock(Enum打卡类型.签退, member))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }

        public IActionResult Tab2()
        {
            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex","STATE"));

            return View(memberResult);
        }

        public IActionResult Tab3()
        {
            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            return View(memberResult);
        }

        public IActionResult Tab4()
        {
            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            ViewData[nameof(GetDepartmentListResult)] = GetDepartmentList();

            return View(memberResult);
        }

        public IActionResult Report()
        {
            return View(ComputeClockMonthReport(2017, 4));
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
            

            var clocks = pinhuaContext.GetTargetDateTargetUserClockRecords(targetDate, userid).OrderBy(p => p.Clocktime);

            foreach (var range in ranges.OrderBy(p => p.Id))
            {
                foreach(var clock in clocks)
                {
                    if(clock.Clocktype == (int)Enum打卡类型.签到)
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
                    if(clock.Clocktype == (int)Enum打卡类型.签退)
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

        private bool CheckClockIn(GetMemberResult member, Enum打卡类型 type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();
            var sType = "签到";

            if (!pinhuaContext.IsInternalNetwork())
            {
                errors.Add($"你的IP地址为 {pinhuaContext.ClientIp()} ,非公司网络");
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
                        where p.Userid == member.userid && p.Clocktime.Value.IsBetween(t1, t2) && p.Clocktype == (int)Enum打卡类型.签到
                        select p;
                if (r.Count() > 0)
                {
                    errors.Add($"当前班段 {r.FirstOrDefault().Clocktime.Value.ToShortTimeString()} 已经有过{sType}记录，请勿重复打卡！");
                    b = false;
                }

            }

            return b;
        }

        private bool CheckClockOut(GetMemberResult member, Enum打卡类型 type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();
            var sType = "签退";

            if (!pinhuaContext.IsInternalNetwork())
            {
                errors.Add($"你的IP地址为 {pinhuaContext.ClientIp()} ,非公司网络");
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
                        where member.userid == p.Userid && p.Clocktime.Value.IsBetween(t1, t2) && p.Clocktype == (int)Enum打卡类型.签退
                        select p;
                if (r.Count() > 0)
                {
                    errors.Add($"当前班段 {r.FirstOrDefault().Clocktime.Value.ToShortTimeString()} 已经有过{sType}记录，请勿重复打卡！");
                    b = false;
                }
            }

            return b;
        }

        private bool InsertWeixinClock(Enum打卡类型 type, GetMemberResult member)
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
                ClockRangeId = pinhuaContext.GetCurrentClockRange().RangeId,
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
            var tokenResult = CommonApi.GetToken(WeixinOptions.CorpId, WeixinOptions.Secret);
            return MailListApi.GetDepartmentList(tokenResult.access_token);
        }

        public ClockComputeModel ComputeClockMonthReport(int year, int month)
        {
            // 获取班段
            var ranges = pinhuaContext.GetCurrentClockRanges();
            // 获取区间内的所有打卡记录
            var records = pinhuaContext.GetTargetMonthClockRecords(year, month);
            // 打卡记录按人分组
            var records分组 = from p in records
                            group p by new { p.Userid, p.Name } into g
                            select g;
            // 开始计算
            var ret = new ClockComputeModel
            {
                year = year,
                month = month,
                users = new List<ClockComputeUserModel>()
            };
            // 插入人员数据
            foreach (var record in records分组)
            {
                ret.users.Add(new ClockComputeUserModel
                {
                    userid = record.Key.Userid,
                    name = record.Key.Name,
                    results = new List<ClockComputeResultModel>()
                });
            }

            // 分日期计算打卡记录
            foreach (var user in ret.users)
            {
                // 为每个成员添加日期
                var days = DateTime.DaysInMonth(ret.year, ret.month);
                for (int i = 0; i != days; i++)
                {
                    user.results.Add(new ClockComputeResultModel
                    {
                        date = new DateTime(year, month, i + 1),
                        details = new List<ClockComputeDetailModel>()
                    });
                }
                foreach (var pp in user.results)
                {
                    var userRecords = records分组.FirstOrDefault(x => x.Key.Userid == user.userid);
                    foreach (var range in ranges)
                    {
                        var dt1 = DateTime.MaxValue;
                        var dt2 = DateTime.MaxValue;
                        var dt1fix = DateTime.MaxValue;
                        var dt2fix = DateTime.MaxValue;
                        // 获取签到签退时间
                        foreach (var clock in userRecords)
                        {
                            if (clock.Clocktype == (int)Enum打卡类型.签到)
                            {
                                range.指定日期的签到区间(pp.date, out var subbegin, out var subend);
                                if (clock.Clocktime.Value.IsBetween(subbegin, subend))
                                {
                                    dt1 = clock.Clocktime.Value;
                                }
                            }
                            if (clock.Clocktype == (int)Enum打卡类型.签退)
                            {
                                range.指定日期的签退区间(pp.date, out var subbegin, out var subend);
                                if (clock.Clocktime.Value.IsBetween(subbegin, subend))
                                {
                                    dt2 = clock.Clocktime.Value;
                                }
                            }
                        }
                        range.指定日期的工作时间区间(pp.date, out var worktime1, out var worktime2);

                        if (dt1 < worktime1 && dt1 != DateTime.MaxValue)
                            dt1fix = worktime1;
                        else if (dt1 >= worktime1 && dt1 != DateTime.MaxValue)
                            dt1fix = dt1;

                        if (dt2 > worktime2 && dt2 != DateTime.MaxValue)
                            if (range.延迟算加班 == "是")
                                dt2fix = dt2;
                            else
                                dt2fix = worktime2;
                        else if (dt2 <= worktime2 && dt2 != DateTime.MaxValue)
                            dt2fix = dt2;
                            
                        var t = dt2fix.DropSeconds().Subtract(dt1fix.DropSeconds());
                        var minutes = t.TotalMinutes > 0 && dt2fix != DateTime.MaxValue && dt1fix != DateTime.MaxValue ? Math.Floor(t.TotalMinutes) : 0;
                        var hours = (minutes - minutes % 6) / 60;
                        pp.details.Add(new ClockComputeDetailModel
                        {
                            hours = (decimal)hours,
                            range = range.ToBorderRangeString(),
                            time1 = dt1 == DateTime.MaxValue ? "" : dt1.ToShortTimeString(),
                            time2 = dt2 == DateTime.MaxValue ? "" : dt2.ToShortTimeString(),
                            time1fix = dt1fix == DateTime.MaxValue ? "" : dt1fix.ToShortTimeString(),
                            time2fix = dt2fix == DateTime.MaxValue ? "" : dt2fix.ToShortTimeString(),
                            state = (dt1 != DateTime.MaxValue && dt2 != DateTime.MaxValue) ? "正常" : "异常"
                        });
                        pp.totalHours += (decimal)hours;
                    }
                }
            }

            return ret;
        }
    }
    public enum Enum打卡类型
    {
        签退,
        签到
    }

    public enum Enum异常说明类型
    {
        未签退,
        未签到
    }
}

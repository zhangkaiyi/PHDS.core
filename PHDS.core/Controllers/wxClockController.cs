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

        public IActionResult ClockIn()
        {
            var b = CheckClockIn(ClockType.ClockIn, out var errors);
            if (b)
                if (!InsertWeixinClock(ClockType.ClockIn))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }
        public IActionResult ClockOut()
        {
            var b = CheckClockOut(ClockType.ClockOut, out var errors);
            if (b)
                if (!InsertWeixinClock(ClockType.ClockOut))
                {
                    errors.Add("数据库操作失败");
                }
            return View(errors);
        }
        public IActionResult Error()
        {
            return View();
        }

        private bool CheckClockIn(ClockType type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();

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
                planDetail.RangeOfClockIn(out var t1, out var t2);
                if (!DateTime.Now.IsBetween(t1, t2))
                {
                    errors.Add($"{planDetail.Name}上班打卡时段{planDetail.ToBeginRangeString()}，当前不在区间内");
                    b = false;
                }
            }

            return b;
        }

        private bool CheckClockOut(ClockType type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();

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
                planDetail.RangeOfClockOut(out var t1, out var t2);
                if (!DateTime.Now.IsBetween(t1, t2))
                {
                    errors.Add($"{planDetail.Name}下班打卡时段{planDetail.ToEndRangeString()}，当前不在区间内");
                    b = false;
                }
            }

            return b;
        }

        private bool InsertWeixinClock(ClockType type)
        {
            var member = HttpContext.Session.GetObjectFromJson<GetMemberResult>("memberResult");

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
    }
    public enum ClockType
    {
        ClockOut,
        ClockIn
    }
}

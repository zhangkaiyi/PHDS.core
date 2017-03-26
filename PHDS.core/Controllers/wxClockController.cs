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

        public IActionResult OAuth(string code, string state)
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
                ViewData["Member"] = memberResult;

            var deptlistResult = MailListApi.GetDepartmentList(tokenResult.access_token);
            if (deptlistResult.errcode == Senparc.Weixin.ReturnCode_QY.请求成功)
                ViewData["DepartmentList"] = deptlistResult;

            return View();
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

            var planDetail = pinhuaContext.GetCurrentWorkPlanDetail();
            if (planDetail == null)
            {
                errors.Add("非工作时段");
                b = false;
            }
            else
            {
                planDetail.RangeOfBegin(out var t1, out var t2);
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

            var planDetail = pinhuaContext.GetCurrentWorkPlanDetail();
            if (planDetail == null)
            {
                errors.Add("非工作时段");
                b = false;
            }
            else
            {
                planDetail.RangeOfEnd(out var t1, out var t2);
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
            var session = HttpContext.Session.GetString("memberResult");
            var member = JsonConvert.DeserializeObject<Senparc.Weixin.QY.AdvancedAPIs.MailList.GetMemberResult>(session);
            var record = new WeixinClock
            {
                Clocktype = (int?)type,
                Weixinid = member.weixinid,
                Userid = member.userid,
                Name = member.name,
                Clocktime = DateTime.Now,
            };

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

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
    public class HomeController : Controller
    {
        public WeixinOptions WeixinOptions;
        public WeixinClockOptions ClockOptions;
        public PinhuaContext PinhuaContext;

        public HomeController(Entities.Pinhua.PinhuaContext pinhuaContext)
        {
            this.PinhuaContext = pinhuaContext;
            this.WeixinOptions = pinhuaContext.WeixinOptions.FirstOrDefault();
            this.ClockOptions = pinhuaContext.WeixinClockOptions.FirstOrDefault();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult OAuth(string code, string state)
        {
            var tokenResult = CommonApi.GetToken(WeixinOptions.CorpId, WeixinOptions.Secret);

            var openInfo = new Senparc.Weixin.QY.AdvancedAPIs.OAuth2.GetUserInfoResult();
            try
            {
                openInfo = OAuth2Api.GetUserId(tokenResult.access_token, code);
            }
            catch(ErrorJsonResultException e) when (e.JsonResult.errcode == Senparc.Weixin.ReturnCode.不合法的oauth_code)
            {
                ViewData["Message"] = Newtonsoft.Json.JsonConvert.SerializeObject(e.JsonResult, Newtonsoft.Json.Formatting.Indented);
                return View();
            }
            //catch (ArgumentNullException e)
            //{
            //    ViewData["Message"] = e.Message;
            //    return View();
            //}

            if (string.IsNullOrEmpty(openInfo.UserId))
            {
                ViewData["Message"] = "非企业人员，考勤功能不可用！";
            }
            else
            {
                ViewData["Member"] = MailListApi.GetMember(tokenResult.access_token, openInfo.UserId);
                ViewData["DepartmentList"] = MailListApi.GetDepartmentList(tokenResult.access_token);
            }
            
            return View();
        }

        public IActionResult AddBeginClock(ClockType type)
        {
            var b = Check(type, out var errors);
            return View(errors);
        }
        public IActionResult Error()
        {
            return View();
        }

        private bool Check(ClockType type, out List<string> errors)
        {
            var b = true;
            errors = new List<string>();

            if (PinhuaContext.WeixinClockOptions.FirstOrDefault().Ip != HttpContext.Connection.RemoteIpAddress.ToString())
            {
                errors.Add("非公司网络");
                b = false;
            }

            var planDetail = PinhuaContext.GetCurrentWorkPlanDetail();
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
    }
    public enum ClockType
    {
        上班打卡,
        下班打卡
    }
}

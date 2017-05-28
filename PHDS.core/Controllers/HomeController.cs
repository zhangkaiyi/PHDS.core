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
        public PinhuaContext pinhuaContext;

        public HomeController(Entities.Pinhua.PinhuaContext pinhuaContext)
        {
            this.pinhuaContext = pinhuaContext;
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
                //ViewData["Member"] = MailListApi.GetMember(tokenResult.access_token, openInfo.UserId);
                ViewData["DepartmentList"] = MailListApi.GetDepartmentList(tokenResult.access_token);
            }
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


    }
}

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
using Senparc.Weixin.QY.AdvancedAPIs.MailList;

namespace PHDS.core.Controllers
{
    public class 异常说明Controller : AController
    {
        public 异常说明Controller(PinhuaContext pinhuaContext):base(pinhuaContext)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult 异常填报()
        {
            return View();
        }
        
        [HttpPost, ActionName(nameof(异常填报))]
        public IActionResult 异常填报_Post(Wx异常说明 model)
        {
            if (model == null)
                return RedirectToAction(nameof(填报失败), "异常说明");

            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            model.用户号 = memberResult.userid;
            model.姓名 = memberResult.name;

            if (!model.时间.HasValue || !model.类型.HasValue || string.IsNullOrEmpty(model.用户号))
                return RedirectToAction(nameof(填报失败), "异常说明");

            var rtId = "148.1";
            var rcId = pinhuaContext.GetNewRcId();

            model.ExcelServerRtid = rtId;
            model.ExcelServerRcid = rcId;
            model.是否通知 = 0;
            model.是否处理 = 0;
            model.填报日期 = DateTime.Now;

            var repCase = new EsRepCase
            {
                RcId = rcId,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = memberResult.name,
                LstFillDate = DateTime.Now,
                FillDate = DateTime.Now,
            };

            pinhuaContext.EsRepCase.Add(repCase);
            pinhuaContext.Wx异常说明.Add(model);
            var iRet = pinhuaContext.SaveChanges();
            if (iRet > 0)
                return RedirectToAction(nameof(填报成功), "异常说明");
            else
                return RedirectToAction(nameof(填报失败), "异常说明");
        }

        public IActionResult 填报成功()
        {
            return View();
        }

        public IActionResult 填报失败()
        {
            return View();
        }

    }
}

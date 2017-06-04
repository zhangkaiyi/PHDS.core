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
    public class 审批待办Controller : AController
    {
        public 审批待办Controller(PinhuaContext pinhuaContext) : base(pinhuaContext)
        {

        }
        public IActionResult 待办审批()
        {
            return View(pinhuaContext.Wx异常说明.ToList());
        }

        [HttpPost, ActionName("Agree")]
        public IActionResult 待办审批Agree(Wx异常说明 model)
        {
            if (model == null)
                return View();

            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().是否处理 = 1;
            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().处理人 = memberResult.name;
            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().处理时间 = DateTime.Now;
            pinhuaContext.SaveChanges();

            return RedirectToAction("Index", "WxClock", new { member = JsonConvert.SerializeObject(memberResult) });
        }

        [HttpPost, ActionName("DisAgree")]
        public IActionResult 待办审批DisAgree(Wx异常说明 model)
        {
            if (model == null)
                return View();

            var memberResult = AppSessions.GetMember();
            if (memberResult == null)
                return Redirect(OAuth2Api.GetCode(WeixinOptions.CorpId, "wx.pinhuadashi.com%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex", "STATE"));

            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().是否处理 = 2;
            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().处理人 = memberResult.name;
            pinhuaContext.Wx异常说明.Where(p => p.ExcelServerRcid == model.ExcelServerRcid).FirstOrDefault().处理时间 = DateTime.Now;
            pinhuaContext.SaveChanges();

            return RedirectToAction("Index", "WxClock", new { member = JsonConvert.SerializeObject(memberResult) });
        }

    }
}

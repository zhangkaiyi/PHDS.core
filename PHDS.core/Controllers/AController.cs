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
    public class AController : Controller
    {
        public WeixinOptions WeixinOptions { get; set; }
        public WeixinClockOptions ClockOptions { get; set; }
        public PinhuaContext pinhuaContext { get; set; }

        public AController(Entities.Pinhua.PinhuaContext pinhuaContext)
        {
            this.pinhuaContext = pinhuaContext;
            this.WeixinOptions = pinhuaContext.WeixinOptions.FirstOrDefault();
            this.ClockOptions = pinhuaContext.WeixinClockOptions.FirstOrDefault();
        }

        public IActionResult Error()
        {
            return View();
        }


    }
}

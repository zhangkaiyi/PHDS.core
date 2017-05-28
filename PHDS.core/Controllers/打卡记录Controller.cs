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
    public class 打卡记录Controller : AController
    {
        public 打卡记录Controller(PinhuaContext pinhuaContext):base(pinhuaContext)
        {

        }

        public IActionResult 所有记录()
        {
            return View();
        }

    }
}

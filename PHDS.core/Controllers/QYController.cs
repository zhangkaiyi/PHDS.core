using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.QY.Entities;
using Senparc.Weixin.MP.Sample.CommonService.QyMessageHandlers;
using System.IO;
using Senparc.Weixin.MP.MvcExtension;
using System.Text;
using PHDS.core.Utility;
using Microsoft.Extensions.Options;

namespace PHDS.core.Controllers
{
    public class QYController : Controller
    {
        public static readonly string Token = "pinhuadashi";//与微信企业账号后台的Token设置保持一致，区分大小写。
        public static readonly string EncodingAESKey = "tM6f5ZGv24QiLmM5n8VSHQeiqZfcRQJ02ozQOVo9H8b";//与微信企业账号后台的EncodingAESKey设置保持一致，区分大小写。
        public static readonly string CorpId = "wx87c90793c5376e09";//与微信企业账号后台的EncodingAESKey设置保持一致，区分大小写。

        /// <summary>
        /// 微信后台验证地址（使用Get），微信企业后台应用的“修改配置”的Url填写如：http://sdk.weixin.senparc.com/qy
        /// </summary>
        [HttpGet]
        [ActionName("Index")]
        public IActionResult Get(string msg_signature = "", string timestamp = "", string nonce = "", string echostr = "")
        {
            //return Content(echostr); //返回随机字符串则表示验证通过
            var verifyUrl = Senparc.Weixin.QY.Signature.VerifyURL(Token, EncodingAESKey, CorpId, msg_signature, timestamp, nonce,
                echostr);
            if (verifyUrl != null)
            {
                return Content(verifyUrl); //返回解密后的随机字符串则表示验证通过
            }
            else
            {
                return Content("如果你在浏览器中看到这句话，说明此地址可以被作为微信公众账号后台的Url，请注意保持Token一致。");
            }
        }

        /// <summary>
        /// 微信后台验证地址（使用Post），微信企业后台应用的“修改配置”的Url填写如：http://sdk.weixin.senparc.com/qy
        /// </summary>
        [HttpPost]
        [ActionName("Index")]
        public IActionResult Post(PostModel postModel)
        {
            var maxRecordCount = 10;

            postModel.Token = Token;
            postModel.EncodingAESKey = EncodingAESKey;
            postModel.CorpId = CorpId;
            
            //自定义MessageHandler，对微信请求的详细判断操作都在这里面。
            var memoryStream = new MemoryStream();
            Request.Body.CopyTo(memoryStream);
            var messageHandler = new QyMyMessageHandler(memoryStream, postModel, maxRecordCount);
            //执行微信处理过程
            messageHandler.Execute();
            //自动返回加密后结果
            return new FixWeixinBugWeixinResult(messageHandler);//为了解决官方微信5.0软件换行bug暂时添加的方法，平时用下面一个方法即可

        }

        /// <summary>
        /// 这是一个最简洁的过程演示
        /// </summary>
        /// <param name="postModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult MiniPost(PostModel postModel)
        {
            var maxRecordCount = 10;

            postModel.Token = Token;
            postModel.EncodingAESKey = EncodingAESKey;
            postModel.CorpId = CorpId;

            //自定义MessageHandler，对微信请求的详细判断操作都在这里面。
            var messageHandler = new QyCustomMessageHandler(Request.Body, postModel, maxRecordCount);
            //执行微信处理过程
            messageHandler.Execute();
            //自动返回加密后结果
            return new FixWeixinBugWeixinResult(messageHandler);
        }
    }

}
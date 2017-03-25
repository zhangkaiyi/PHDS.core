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
        public static readonly string Token = "pinhuadashi";//��΢����ҵ�˺ź�̨��Token���ñ���һ�£����ִ�Сд��
        public static readonly string EncodingAESKey = "tM6f5ZGv24QiLmM5n8VSHQeiqZfcRQJ02ozQOVo9H8b";//��΢����ҵ�˺ź�̨��EncodingAESKey���ñ���һ�£����ִ�Сд��
        public static readonly string CorpId = "wx87c90793c5376e09";//��΢����ҵ�˺ź�̨��EncodingAESKey���ñ���һ�£����ִ�Сд��

        /// <summary>
        /// ΢�ź�̨��֤��ַ��ʹ��Get����΢����ҵ��̨Ӧ�õġ��޸����á���Url��д�磺http://sdk.weixin.senparc.com/qy
        /// </summary>
        [HttpGet]
        [ActionName("Index")]
        public IActionResult Get(string msg_signature = "", string timestamp = "", string nonce = "", string echostr = "")
        {
            //return Content(echostr); //��������ַ������ʾ��֤ͨ��
            var verifyUrl = Senparc.Weixin.QY.Signature.VerifyURL(Token, EncodingAESKey, CorpId, msg_signature, timestamp, nonce,
                echostr);
            if (verifyUrl != null)
            {
                return Content(verifyUrl); //���ؽ��ܺ������ַ������ʾ��֤ͨ��
            }
            else
            {
                return Content("�������������п�����仰��˵���˵�ַ���Ա���Ϊ΢�Ź����˺ź�̨��Url����ע�Ᵽ��Tokenһ�¡�");
            }
        }

        /// <summary>
        /// ΢�ź�̨��֤��ַ��ʹ��Post����΢����ҵ��̨Ӧ�õġ��޸����á���Url��д�磺http://sdk.weixin.senparc.com/qy
        /// </summary>
        [HttpPost]
        [ActionName("Index")]
        public IActionResult Post(PostModel postModel)
        {
            var maxRecordCount = 10;

            postModel.Token = Token;
            postModel.EncodingAESKey = EncodingAESKey;
            postModel.CorpId = CorpId;
            
            //�Զ���MessageHandler����΢���������ϸ�жϲ������������档
            var memoryStream = new MemoryStream();
            Request.Body.CopyTo(memoryStream);
            var messageHandler = new QyMyMessageHandler(memoryStream, postModel, maxRecordCount);
            //ִ��΢�Ŵ������
            messageHandler.Execute();
            //�Զ����ؼ��ܺ���
            return new FixWeixinBugWeixinResult(messageHandler);//Ϊ�˽���ٷ�΢��5.0�������bug��ʱ��ӵķ�����ƽʱ������һ����������

        }

        /// <summary>
        /// ����һ������Ĺ�����ʾ
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

            //�Զ���MessageHandler����΢���������ϸ�жϲ������������档
            var messageHandler = new QyCustomMessageHandler(Request.Body, postModel, maxRecordCount);
            //ִ��΢�Ŵ������
            messageHandler.Execute();
            //�Զ����ؼ��ܺ���
            return new FixWeixinBugWeixinResult(messageHandler);
        }
    }

}
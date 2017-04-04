﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：QyCustomMessageHandler.cs
    文件功能描述：自定义QyMessageHandler
    
    
    创建标识：Senparc - 20150312
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Sample.CommonService.QyMessageHandler;
using Senparc.Weixin.QY.Entities;
using Senparc.Weixin.QY.MessageHandlers;
using System.Text.Encodings.Web;

namespace Senparc.Weixin.MP.Sample.CommonService.QyMessageHandlers
{
    public class QyMyMessageHandler : QyMessageHandler<QyCustomMessageContext>
    {
        public QyMyMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0)
            : base(inputStream, postModel, maxRecordCount)
        {
        }

        public override IResponseMessageBase OnTextRequest(RequestMessageText requestMessage)
        {
            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            var code = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx87c90793c5376e09&redirect_uri=122.225.47.230%3A6016%2Fwxclock%2Foauth%3Freturnurl%3D%252Fwxclock%252Findex&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect";
            responseMessage.Content = $"您发送了消息：{requestMessage.Content}，OpenId：{this.WeixinOpenId}，Code：{code}";
            return responseMessage;
        }

        public override IResponseMessageBase OnImageRequest(RequestMessageImage requestMessage)
        {
            var responseMessage = CreateResponseMessage<ResponseMessageImage>();
            responseMessage.Image.MediaId = requestMessage.MediaId;
            return responseMessage;
        }

        public override IResponseMessageBase OnEvent_PicPhotoOrAlbumRequest(RequestMessageEvent_Pic_Photo_Or_Album requestMessage)
        {
            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "您刚发送的图片如下：";
            return responseMessage;
        }

        public override IResponseMessageBase OnEvent_LocationRequest(RequestMessageEvent_Location requestMessage)
        {
            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = string.Format("位置坐标 {0} - {1}", requestMessage.Latitude, requestMessage.Longitude);
            return responseMessage;
        }

        public override QY.Entities.IResponseMessageBase DefaultResponseMessage(QY.Entities.IRequestMessageBase requestMessage)
        {
            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "这是一条没有找到合适回复信息的默认消息。";
            return null;
        }
    }
}

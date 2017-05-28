using Senparc.Weixin.QY.AdvancedAPIs.MailList;
using Zky.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PHDS.core.Utility
{
    static public class AppSessions
    {
        static private string memberInfoKey = "wxCurrentMemberInfo";

        static public void SetMemberString(string info)
        {
            Zky.Utility.HttpContext.Current.Session.SetString(memberInfoKey, info);
        }

        static public string GetMemberString()
        {
            return Zky.Utility.HttpContext.Current.Session.GetString(memberInfoKey) ?? string.Empty;
        }

        static public void SetMember(GetMemberResult value)
        {
            Zky.Utility.HttpContext.Current.Session.SetObjectAsJson(memberInfoKey, value);
        }

        static public GetMemberResult GetMember()
        {
            return Zky.Utility.HttpContext.Current.Session.GetObjectFromJson<GetMemberResult>(memberInfoKey);
        }

        static public string Test(int x)
        {
            return x.ToString();
        }
    }
}

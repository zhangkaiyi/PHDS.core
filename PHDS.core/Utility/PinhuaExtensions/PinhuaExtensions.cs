using Microsoft.EntityFrameworkCore;
using PHDS.core.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Utility
{
    public static class HttpContext
    {
        public static IServiceProvider ServiceProvider;
        public static Microsoft.AspNetCore.Http.HttpContext Current
        {
            get
            {
                object factory = ServiceProvider.GetService(typeof(Microsoft.AspNetCore.Http.IHttpContextAccessor));
                Microsoft.AspNetCore.Http.HttpContext context = ((Microsoft.AspNetCore.Http.HttpContextAccessor)factory).HttpContext;
                return context;
            }
        }
    }

    public static class PinhuaContextExtensions
    {
        /// <summary>
        /// 判断是不是公司内部网络，公司网络信息在数据库中
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool IsInternalNetwork(this PinhuaContext context)
        {
            var clockOptions = context.WeixinClockOptions.FirstOrDefault();
            return HttpContext.Current.Connection.RemoteIpAddress.ToString() == clockOptions.Ip;
        }

        /// <summary>
        /// 获取最大的Id
        /// </summary>
        /// <param name="context"></param>
        /// <param name="idName">要获取Id的代号</param>
        /// <param name="n">Id要增大的数</param>
        /// <returns></returns>
        public static int GetNewId(this PinhuaContext context, int idName, int n)
        {
            context.Database.ExecuteSqlCommand($"exec GetNewId_s @id, @n", new[]{
                 new SqlParameter("id", idName) ,new SqlParameter("n", n)
            });

            var obj = context.EsSysIdS
                .Where(p => p.IdName == idName && p.IdDate.Year == DateTime.Now.Year && p.IdDate.Month == DateTime.Now.Month && p.IdDate.Day == DateTime.Now.Day)
                .FirstOrDefault();

            return obj == null ? 0 : obj.MaxId;
        }

        /// <summary>
        /// 获取新的rcid文本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetNewRcId(this PinhuaContext context)
        {
            var newId = context.GetNewId(26, 1);
            var rcId = "rc" + DateTime.Now.ToString("yyyyMMdd") + newId.ToString("D5");

            return newId == 0 ? "" : rcId;
        }

        /// <summary>
        /// 获取当前班段信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static WeixinWorkPlanDetail GetCurrentClockRange(this PinhuaContext context)
        {
            var ranges = context.GetCurrentClockRanges();

            foreach (var p in ranges)
            {
                p.RangeOfFullClockTime(out var left, out var right);

                if (DateTime.Now.IsBetween(left, right))
                    return p;
            }
            return null;
        }

        /// <summary>
        /// 获取当天打卡计划
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static WeixinWorkPlan GetCurrentClockPlan(this PinhuaContext context)
        {
            var plan = context.WeixinWorkPlan.Where(p => p.Id == 1).FirstOrDefault();
            return plan;
        }

        /// <summary>
        /// 获取当天打卡区间集合
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<WeixinWorkPlanDetail> GetCurrentClockRanges(this PinhuaContext context)
        {
            var plan = context.GetCurrentClockPlan();
            if (plan == null)
                return null;
            var ranges = context.WeixinWorkPlanDetail.Where(p => p.ExcelServerRcid == plan.ExcelServerRcid);
            return ranges.ToList();
        }

        /// <summary>
        /// 获取当天打卡区间最早与最晚时间
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool GetCurrentClockRangesBorder(this PinhuaContext context, out DateTime earliest, out DateTime latest)
        {
            var now = DateTime.Now;
            earliest = DateTime.MaxValue;
            latest = DateTime.MinValue;

            var ranges = context.GetCurrentClockRanges();
            if (ranges == null)
                return false;

            foreach (var range in ranges)
            {
                var t1 = range.BeginTime.Value.AddMinutes(-range.BeginEarlier.Value).ConvertDateToToday();
                if (t1 < earliest)
                    earliest = t1;
                var t2 = range.EndTime.Value.AddMinutes(range.EndLater.Value).ConvertDateToToday().AddDays(range.CrossAday.Value);
                if(t2 > latest)
                    latest = t2;
            }
            if (now <= latest && now <= earliest)   // 比最早时间早，说明在第二天，比最晚时间早，说明第一天的还没结束
            {
                earliest = earliest.AddDays(-1);
                latest = latest.AddDays(-1);
            }

            return true;
        }

        /// <summary>
        /// 获取当天考勤记录集合
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<WeixinClock> GetCurrentClockData(this PinhuaContext context, string userid)
        {
            var result = new List<WeixinClock>();
            var bret = context.GetCurrentClockRangesBorder(out var earliest, out var latest);
            if (bret)
            {
                foreach (var clockinfo in context.WeixinClock.Where(p => p.Userid == userid))
                {
                    if (clockinfo.Clocktime.Value.IsBetween(earliest, latest))
                        result.Add(clockinfo);
                }
            }
            return result;
        }
    }
}

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
            var detailList = from p1 in context.WeixinWorkPlan
                             join p2 in context.WeixinWorkPlanDetail
                             on p1.ExcelServerRcid equals p2.ExcelServerRcid
                             where p1.Id == 1
                             select p2;

            foreach (var p in detailList)
            {
                p.RangeOfFullClockTime(out var left, out var right);

                if (DateTime.Now.IsBetween(left, right))
                    return p;
            }
            return null;
        }
    }
    public static class WeixinClockRangeExtensions
    {
        public static string ToRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfWorkingTime(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBeginRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfClockIn(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToEndRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfClockOut(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBorderRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfFullClockTime(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static bool RangeOfWorkingTime(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.BeginTime.Value.ConvertDateToToday();
            rangeRight = item.EndTime.Value.ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }

        public static bool RangeOfClockIn(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            rangeRight = item.BeginTime.Value.AddMinutes(item.BeginLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }

        public static bool RangeOfClockOut(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.EndTime.Value.AddMinutes(-item.EndEarlier.Value).ConvertDateToToday();
            rangeRight = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }

        public static bool RangeOfFullClockTime(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            rangeRight = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }

        public static bool RangeOfStartClockInToEndTime(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            rangeRight = item.EndTime.Value.ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }

        public static bool RangeOfBeginTimeToStopClockOut(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = DateTime.MinValue;
            rangeRight = DateTime.MinValue;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            rangeLeft = item.BeginTime.Value.ConvertDateToToday();
            rangeRight = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
            return true;
        }
        private static bool IsEveryDatetimeNotNull(this WeixinWorkPlanDetail item)
        {
            if (item == null)
                return false;
            if (item.BeginEarlier.HasValue && item.BeginTime.HasValue && item.BeginLater.HasValue
                && item.EndEarlier.HasValue && item.EndTime.HasValue && item.EndLater.HasValue)
                return true;
            else
                return false;
        }

        public static bool IsRangeOfClockIn(this WeixinWorkPlanDetail item)
        {
            item.RangeOfClockIn(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfClockOut(this WeixinWorkPlanDetail item)
        {
            item.RangeOfClockOut(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        public static bool IsRangeOfFullClockTime(this WeixinWorkPlanDetail item)
        {
           item.RangeOfFullClockTime(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        public static bool IsRangeOfWorkingTime(this WeixinWorkPlanDetail item)
        {
            item.RangeOfWorkingTime(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        
        public static bool IsRangeOfStartClockInToEndTime(this WeixinWorkPlanDetail item)
        {
            item.RangeOfStartClockInToEndTime(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfBeginTimeToStopClockOut(this WeixinWorkPlanDetail item)
        {
            item.RangeOfBeginTimeToStopClockOut(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using PHDS.core.Entities;
using PHDS.core.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Utility
{
    public static class WeixinClockRangeExtensions
    {
        public static string ToRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfWorkingTime(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBorderRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfFullClockTime(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static bool RangeOfWorkingTime(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertDateToToday();
            end = item.Ending.Value.ConvertDateToToday();

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool RangeOfFullClockTime(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertDateToToday().AddMinutes(-item.MoveUp.Value);
            end = item.Ending.Value.ConvertDateToToday().AddMinutes(item.PutOff.Value);

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool RangeOfClockIn(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertDateToToday().AddMinutes(-item.MoveUp.Value);
            end = item.Ending.Value.ConvertDateToToday();

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool RangeOfClockOut(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertDateToToday();
            end = item.Ending.Value.ConvertDateToToday().AddMinutes(item.PutOff.Value);

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }
        private static bool IsEveryDatetimeNotNull(this WeixinWorkPlanDetail item)
        {
            if (item == null)
                return false;
            if (item.MoveUp.HasValue && item.Beginning.HasValue && item.Ending.HasValue && item.PutOff.HasValue)
                return true;
            else
                return false;
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

    }
}

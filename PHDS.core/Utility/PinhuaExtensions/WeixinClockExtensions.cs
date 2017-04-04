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
            今天的工作时间区间(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBorderRangeString(this WeixinWorkPlanDetail item)
        {
            今天的打卡开始到结束区间(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static bool 今天的工作时间区间(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            var now = DateTime.Now;
            
            if (!item.指定日期的工作时间区间(now, out begin, out end))
                return false;
         
            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool 指定日期的工作时间区间(this WeixinWorkPlanDetail item, DateTime target, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertToTargetDate(target);
            end = item.Ending.Value.ConvertToTargetDate(target);

            return true;
        }

        public static string 指定日期的工作时间区间转文字(this WeixinWorkPlanDetail item, DateTime target)
        {
            item.指定日期的工作时间区间(target, out var begin, out var end);
            return begin.ToShortTimeString() + " 到 " + end.ToShortTimeString();
        }

        public static bool 今天的打卡开始到结束区间(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            var now = DateTime.Now;

            if (!item.指定日期的打卡开始到结束区间(now, out begin, out end))
                return false;

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool 指定日期的打卡开始到结束区间(this WeixinWorkPlanDetail item, DateTime target, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertToTargetDate(target).AddMinutes(-item.MoveUp.Value);
            end = item.Ending.Value.ConvertToTargetDate(target).AddMinutes(item.PutOff.Value);

            return true;
        }

        public static bool 今天的签到区间(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            var now = DateTime.Now;

            if (!item.指定日期的签到区间(now, out begin, out end))
                return false;

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool 指定日期的签到区间(this WeixinWorkPlanDetail item,DateTime target, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertToTargetDate(target).AddMinutes(-item.MoveUp.Value);
            end = item.Ending.Value.ConvertToTargetDate(target);

            return true;
        }

        public static bool 今天的签退区间(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            var now = DateTime.Now;

            if (!item.指定日期的签退区间(now, out begin, out end))
                return false;

            if (now <= begin)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                begin = begin.AddDays(-1);
                end = end.AddDays(-1);
            }

            return true;
        }

        public static bool 指定日期的签退区间(this WeixinWorkPlanDetail item, DateTime target, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.Beginning.Value.ConvertToTargetDate(target);
            end = item.Ending.Value.ConvertToTargetDate(target).AddMinutes(item.PutOff.Value);

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
            item.今天的打卡开始到结束区间(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        public static bool IsRangeOfWorkingTime(this WeixinWorkPlanDetail item)
        {
            item.今天的工作时间区间(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfClockIn(this WeixinWorkPlanDetail item)
        {
            item.今天的签到区间(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfClockOut(this WeixinWorkPlanDetail item)
        {
            item.今天的签退区间(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

    }
}

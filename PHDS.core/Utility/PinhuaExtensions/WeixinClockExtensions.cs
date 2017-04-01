using Microsoft.EntityFrameworkCore;
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

        public static bool RangeOfClockIn2(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;

            begin = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            end = item.EndTime.Value.ConvertDateToToday();

            if(item.CrossAday.Value == 0)
            {
                if(now >= DateTime.Now.Date && now < begin)
                {
                    begin = begin.AddDays(-1);
                    end = end.AddDays(-1);
                }
            }

            if (item.CrossAday.Value == 1) {
                end = end.AddDays(item.CrossAday.Value);

                if (now < begin && now >= DateTime.Now.Date)
                {
                    begin = begin.AddDays(-item.CrossAday.Value);
                    end = end.AddDays(-item.CrossAday.Value);
                }
            }
            return true;
        }

        public static bool RangeOfClockOut2(this WeixinWorkPlanDetail item, out DateTime begin, out DateTime end)
        {
            begin = DateTime.MinValue;
            end = DateTime.MinValue;
            var now = DateTime.Now;
            if (!item.IsEveryDatetimeNotNull())
                return false;
             
            begin = item.BeginTime.Value.ConvertDateToToday();
            end = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();

            if (item.CrossAday.Value == 0)
            {
                if (now >= DateTime.Now.Date && now < begin)
                {
                    begin = begin.AddDays(-1);
                    end = end.AddDays(-1);
                }
            }

            if (item.CrossAday.Value == 1)
            {
                end = end.AddDays(item.CrossAday.Value);

                if (now < begin && now >= DateTime.Now.Date)
                {
                    begin = begin.AddDays(-item.CrossAday.Value);
                    end = end.AddDays(-item.CrossAday.Value);
                }
            }
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
            item.RangeOfClockIn2(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfBeginTimeToStopClockOut(this WeixinWorkPlanDetail item)
        {
            item.RangeOfClockOut2(out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

    }
}

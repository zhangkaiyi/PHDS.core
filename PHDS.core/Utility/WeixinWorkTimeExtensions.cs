using Microsoft.EntityFrameworkCore;
using PHDS.core.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Utility
{
    public static class PinhuaContextExtensions
    {
        public static WeixinWorkPlanDetail GetCurrentWorkPlanDetail(this PinhuaContext context)
        {
            var detailList = from p1 in context.WeixinWorkPlan
                             join p2 in context.WeixinWorkPlanDetail
                             on p1.ExcelServerRcid equals p2.ExcelServerRcid
                             where p1.Id == 1
                             select p2;

            foreach (var p in detailList)
            {
                p.RangeOfBorder(out var left, out var right);

                if (DateTime.Now.IsBetween(left, right))
                    return p;
            }
            return null;
        }
        public static string CurrentRangeName(this PinhuaContext context)
        {
            var name = string.Empty;
            var current = GetCurrentWorkPlanDetail(context);
            name = current.Name;
            return name;
        }
    }
    public static class WeixinWorkPlanDetailExtensions
    {
        public static string ToRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfWorkTime(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBeginRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfBegin(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToEndRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfEnd(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static string ToBorderRangeString(this WeixinWorkPlanDetail item)
        {
            RangeOfBorder(item, out var left, out var right);
            return item == null ? "" : $"{left.ToShortTimeString()}～{right.ToShortTimeString()}";
        }

        public static void RangeOfWorkTime(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = item.BeginTime.Value.ConvertDateToToday();
            rangeRight = item.EndTime.Value.ConvertDateToToday();
            //if (rangeLeft > rangeRight)
            //    rangeLeft = rangeLeft.AddDays(-1);
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
        }

        public static void RangeOfBegin(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            rangeRight = item.BeginTime.Value.AddMinutes(item.BeginLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
        }

        public static void RangeOfEnd(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = item.EndTime.Value.AddMinutes(-item.EndEarlier.Value).ConvertDateToToday();
            rangeRight = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
        }

        public static void RangeOfBorder(this WeixinWorkPlanDetail item, out DateTime rangeLeft, out DateTime rangeRight)
        {
            rangeLeft = item.BeginTime.Value.AddMinutes(-item.BeginEarlier.Value).ConvertDateToToday();
            rangeRight = item.EndTime.Value.AddMinutes(item.EndLater.Value).ConvertDateToToday();
            if (rangeLeft > rangeRight)
                if (DateTime.Now < rangeLeft)
                    rangeLeft = rangeLeft.AddDays(-1);
                else
                    rangeRight = rangeRight.AddDays(1);
        }

        public static bool IsRangeOfBegin(this WeixinWorkPlanDetail item)
        {
            RangeOfBegin(item, out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

        public static bool IsRangeOfEnd(this WeixinWorkPlanDetail item)
        {
            RangeOfEnd(item, out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        public static bool IsRangeOfBorder(this WeixinWorkPlanDetail item)
        {
            RangeOfBorder(item, out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }
        public static bool IsRangeOfWorkTime(this WeixinWorkPlanDetail item)
        {
            RangeOfWorkTime(item, out var left, out var right);
            return DateTime.Now.IsBetween(left, right);
        }

    }
}

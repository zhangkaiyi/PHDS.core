﻿using PHDS.core.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public static class DateTimeExtensions
    {
        public static DateTime ConvertDateToToday(this DateTime datetime)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                , datetime.Hour, datetime.Minute, datetime.Second);
        }

        public static bool IsBetween(this DateTime datetime,DateTime left,DateTime right)
        {
            return left <= datetime && datetime <= right;
        }

        public static double AsJavascriptsOrUnixTicks(this DateTime datetime)
        {
            DateTime date1 = datetime.ToUniversalTime();
            DateTime date2 = new DateTime(1970, 1, 1);
            TimeSpan ts = new TimeSpan(date1.Ticks - date2.Ticks);
            return ts.TotalMilliseconds;
        }

        public static string ToShortTimeString(this DateTime datetime)
        {
            return datetime.ToString("HH:mm");
        }
    }
}
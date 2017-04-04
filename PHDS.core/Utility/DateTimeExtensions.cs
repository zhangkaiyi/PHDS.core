using PHDS.core.Entities.Pinhua;
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

        public static DateTime ConvertToTargetDate(this DateTime datetime, DateTime target)
        {
            return new DateTime(target.Year, target.Month, target.Day
                , datetime.Hour, datetime.Minute, datetime.Second);
        }

        public static DateTime DropSeconds(this DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, 0);
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

        public static bool IsToday(this DateTime dt)
        {
            var b = dt.Year == DateTime.Now.Year
                && dt.Month == DateTime.Now.Month
                && dt.Day == DateTime.Now.Day;
            return b;
        }

        public static bool isSameTime(this DateTime dt)
        {
            var b = dt.Hour == DateTime.Now.Hour
                && dt.Minute == DateTime.Now.Minute
                && dt.Second == DateTime.Now.Second;
            return b;
        }
    }
}

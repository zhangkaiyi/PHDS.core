using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PHDS.core.Controllers;
using PHDS.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Utility
{
    public static class Reports
    {
        private static IApplicationBuilder _app { get; set; }
        private static Entities.Pinhua.PinhuaContext pinhuaContext => _app.ApplicationServices.GetRequiredService<Entities.Pinhua.PinhuaContext>();

        public static IApplicationBuilder UseUtility(this IApplicationBuilder app)
        {
            _app = app;
            return app;
        }
        public static ClockComputeModel 计算月报表(int year, int month)
        {
            // 获取班段
            var ranges = pinhuaContext.GetCurrentClockRanges();
            // 获取区间内的所有打卡记录
            var records = pinhuaContext.GetTargetMonthClockRecords(year, month);
            // 打卡记录按人分组
            var records分组 = from p in records
                            group p by new { p.Userid, p.Name } into g
                            select g;
            // 开始计算
            var ret = new ClockComputeModel
            {
                year = year,
                month = month,
                users = new List<ClockComputeUserModel>()
            };
            // 插入人员数据
            foreach (var record in records分组)
            {
                ret.users.Add(new ClockComputeUserModel
                {
                    userid = record.Key.Userid,
                    name = record.Key.Name,
                    results = new List<ClockComputeResultModel>()
                });
            }

            // 分日期计算打卡记录
            foreach (var user in ret.users)
            {
                // 为每个成员添加日期
                var days = DateTime.DaysInMonth(ret.year, ret.month);
                for (int i = 0; i != days; i++)
                {
                    user.results.Add(new ClockComputeResultModel
                    {
                        date = new DateTime(year, month, i + 1),
                        details = new List<ClockComputeDetailModel>()
                    });
                }
                foreach (var pp in user.results)
                {
                    var userRecords = records分组.FirstOrDefault(x => x.Key.Userid == user.userid);
                    foreach (var range in ranges)
                    {
                        var dt1 = DateTime.MaxValue;
                        var dt2 = DateTime.MaxValue;
                        var dt1fix = DateTime.MaxValue;
                        var dt2fix = DateTime.MaxValue;
                        // 获取签到签退时间
                        foreach (var clock in userRecords)
                        {
                            if (clock.Clocktype == (int)Enum打卡类型.签到)
                            {
                                range.指定日期的签到区间(pp.date, out var subbegin, out var subend);
                                if (clock.Clocktime.Value.IsBetween(subbegin, subend))
                                {
                                    dt1 = clock.Clocktime.Value;
                                }
                            }
                            if (clock.Clocktype == (int)Enum打卡类型.签退)
                            {
                                range.指定日期的签退区间(pp.date, out var subbegin, out var subend);
                                if (clock.Clocktime.Value.IsBetween(subbegin, subend))
                                {
                                    dt2 = clock.Clocktime.Value;
                                }
                            }
                        }
                        range.指定日期的工作时间区间(pp.date, out var worktime1, out var worktime2);

                        if (dt1 < worktime1 && dt1 != DateTime.MaxValue)
                            dt1fix = worktime1;
                        else if (dt1 >= worktime1 && dt1 != DateTime.MaxValue)
                            dt1fix = dt1;

                        if (dt2 > worktime2 && dt2 != DateTime.MaxValue)
                            if (range.延迟算加班 == "是")
                                dt2fix = dt2;
                            else
                                dt2fix = worktime2;
                        else if (dt2 <= worktime2 && dt2 != DateTime.MaxValue)
                            dt2fix = dt2;

                        var t = dt2fix.DropSeconds().Subtract(dt1fix.DropSeconds());
                        var minutes = t.TotalMinutes > 0 && dt2fix != DateTime.MaxValue && dt1fix != DateTime.MaxValue ? Math.Floor(t.TotalMinutes) : 0;
                        var hours = (minutes - minutes % 6) / 60;
                        pp.details.Add(new ClockComputeDetailModel
                        {
                            hours = (decimal)hours,
                            range = range.ToBorderRangeString(),
                            time1 = dt1 == DateTime.MaxValue ? "" : dt1.ToShortTimeString(),
                            time2 = dt2 == DateTime.MaxValue ? "" : dt2.ToShortTimeString(),
                            time1fix = dt1fix == DateTime.MaxValue ? "" : dt1fix.ToShortTimeString(),
                            time2fix = dt2fix == DateTime.MaxValue ? "" : dt2fix.ToShortTimeString(),
                            state = (dt1 != DateTime.MaxValue && dt2 != DateTime.MaxValue) ? "正常" : "异常"
                        });
                        pp.totalHours += (decimal)hours;
                    }
                }
            }

            return ret;
        }

    }
}

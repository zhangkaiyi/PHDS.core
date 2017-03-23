using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 考勤明细
    {
        public string 人员编号 { get; set; }
        public string 姓名 { get; set; }
        public DateTime 日期 { get; set; }
        public decimal? 正常出勤 { get; set; }
        public decimal? 加班 { get; set; }
        public string 上班1 { get; set; }
        public string 下班1 { get; set; }
        public string 上班2 { get; set; }
        public string 下班2 { get; set; }
        public string 上班3 { get; set; }
        public string 下班3 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 状态 { get; set; }
        public int? 当日工龄 { get; set; }
        public int? 上月工龄 { get; set; }
        public DateTime? 首打日期 { get; set; }
    }
}

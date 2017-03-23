using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 考勤卡号变动
    {
        public string 状态 { get; set; }
        public string 卡号 { get; set; }
        public DateTime? 起始日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public DateTime? 截止日期 { get; set; }
        public int Pk { get; set; }
    }
}

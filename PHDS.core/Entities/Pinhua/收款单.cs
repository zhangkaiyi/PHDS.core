using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 收款单
    {
        public string 收款单号 { get; set; }
        public DateTime? 收款日期 { get; set; }
        public string 收款类型 { get; set; }
        public decimal? 收款金额 { get; set; }
        public string 备注 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 收款单位 { get; set; }
        public string 单位编号 { get; set; }
    }
}

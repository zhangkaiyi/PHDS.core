using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 付款单
    {
        public string 付款单号 { get; set; }
        public string 付款单位 { get; set; }
        public string 单位编号 { get; set; }
        public DateTime? 付款日期 { get; set; }
        public string 付款类型 { get; set; }
        public decimal? 付款金额 { get; set; }
        public string 备注 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}

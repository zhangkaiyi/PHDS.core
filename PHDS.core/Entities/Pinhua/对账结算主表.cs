using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 对账结算主表
    {
        public DateTime 日期 { get; set; }
        public decimal? 应收 { get; set; }
        public decimal? 应付 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 单位编号 { get; set; }
        public string 单位名称 { get; set; }
    }
}

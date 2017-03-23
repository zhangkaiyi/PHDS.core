using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 应收款对账单
    {
        public string 客户编码 { get; set; }
        public string 客户名称 { get; set; }
        public DateTime 对账日期 { get; set; }
        public decimal? 对账金额 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}

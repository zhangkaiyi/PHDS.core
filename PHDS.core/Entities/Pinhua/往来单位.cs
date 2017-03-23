using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 往来单位
    {
        public string 单位编号 { get; set; }
        public string 单位名称 { get; set; }
        public string 电话 { get; set; }
        public string 传真 { get; set; }
        public string 单位地址 { get; set; }
        public DateTime? 登记日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 单位类型 { get; set; }
        public string 单位性质 { get; set; }
        public int? Rank { get; set; }
    }
}

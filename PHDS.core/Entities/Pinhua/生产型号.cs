using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 生产型号
    {
        public string 型号 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int 自增 { get; set; }
        public int? 排序等级 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 图形登记表
    {
        public string 图形编号 { get; set; }
        public string 图形名称 { get; set; }
        public string 图形 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 描述 { get; set; }
        public int? 标识 { get; set; }
    }
}

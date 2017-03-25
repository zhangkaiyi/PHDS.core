using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class WeixinClockOptions
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class WeixinClock
    {
        public int Id { get; set; }
        public int? Clocktype { get; set; }
        public string Weixinid { get; set; }
        public string Userid { get; set; }
        public string Name { get; set; }
        public DateTime? Clocktime { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int? ClockRangeId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class WeixinWorkPlanDetail
    {
        public string Name { get; set; }
        public int? BeginEarlier { get; set; }
        public DateTime? BeginTime { get; set; }
        public int? BeginLater { get; set; }
        public int? EndEarlier { get; set; }
        public DateTime? EndTime { get; set; }
        public int? EndLater { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int Id { get; set; }
    }
}

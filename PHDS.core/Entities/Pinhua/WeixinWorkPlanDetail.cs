using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class WeixinWorkPlanDetail
    {
        public string Name { get; set; }
        public int? MoveUp { get; set; }
        public DateTime? Beginning { get; set; }
        public DateTime? Ending { get; set; }
        public int? PutOff { get; set; }
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

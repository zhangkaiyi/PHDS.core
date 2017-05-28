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
        public DateTime? 休息开始时间 { get; set; }
        public DateTime? 休息结束时间 { get; set; }
        public int? 中途休息 { get; set; }
        public string 必须打上班卡 { get; set; }
        public string 必须打下班卡 { get; set; }
        public string 延迟算加班 { get; set; }
        public int? RangeId { get; set; }
    }
}

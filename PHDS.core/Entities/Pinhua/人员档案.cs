using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 人员档案
    {
        public string 人员编号 { get; set; }
        public DateTime? 登记时间 { get; set; }
        public string 姓名 { get; set; }
        public string 状态 { get; set; }
        public string 性别 { get; set; }
        public string 证件号码 { get; set; }
        public DateTime? 出生年月 { get; set; }
        public string 联系电话 { get; set; }
        public string 联系地址 { get; set; }
        public DateTime? 离职时间 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public DateTime? 入职时间 { get; set; }
        public string 考勤班次 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class Wx异常说明
    {
        public int Id { get; set; }
        public string 用户号 { get; set; }
        public int? 类型 { get; set; }
        public DateTime? 时间 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 原因 { get; set; }
        public int? 是否通知 { get; set; }
        public int? 是否处理 { get; set; }
        public string 姓名 { get; set; }
        public DateTime? 填报时间 { get; set; }
        public DateTime? 处理时间 { get; set; }
        public string 处理人 { get; set; }
    }
}

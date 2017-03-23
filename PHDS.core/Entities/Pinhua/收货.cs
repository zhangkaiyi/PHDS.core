using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 收货
    {
        public string 供应商编号 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 供应商名称 { get; set; }
        public string 单号 { get; set; }
        public DateTime? 日期 { get; set; }
        public string 业务类型 { get; set; }
        public string 业务描述 { get; set; }
        public string 创建者 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 发货Detail
    {
        public string 编号 { get; set; }
        public string 代号 { get; set; }
        public string 规格 { get; set; }
        public string 工艺 { get; set; }
        public string 木种 { get; set; }
        public string 计价单位 { get; set; }
        public decimal? Pcs { get; set; }
        public decimal? 单价 { get; set; }
        public decimal? 金额 { get; set; }
        public string 描述 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 类型 { get; set; }
        public decimal? 单位数量 { get; set; }
        public string 标记 { get; set; }
        public int Pk { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 物料分类
    {
        public string 上级编码 { get; set; }
        public string 上级名称 { get; set; }
        public string 上级全称 { get; set; }
        public string 本级编码 { get; set; }
        public string 本级名称 { get; set; }
        public string 完整编码 { get; set; }
        public string 全称 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int? 级数 { get; set; }
        public int? 排序 { get; set; }
    }
}

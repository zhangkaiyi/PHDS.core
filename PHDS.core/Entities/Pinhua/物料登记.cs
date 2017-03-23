using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 物料登记
    {
        public string 状态 { get; set; }
        public string 编号 { get; set; }
        public string 类型 { get; set; }
        public string 描述 { get; set; }
        public string 型号 { get; set; }
        public string 规格 { get; set; }
        public string 工艺 { get; set; }
        public string 木种 { get; set; }
        public string 木种个数 { get; set; }
        public string 图形编号 { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string 分类编号 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public decimal? 面皮厚度 { get; set; }
    }
}

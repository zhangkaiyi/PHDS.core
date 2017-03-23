using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class 物料登记Old
    {
        public string 状态 { get; set; }
        public string 编号 { get; set; }
        public string 类型 { get; set; }
        public string 名称 { get; set; }
        public string 代号 { get; set; }
        public string 规格 { get; set; }
        public string 工艺 { get; set; }
        public string 木种 { get; set; }
        public string 木种数 { get; set; }
        public string 单位组编号 { get; set; }
        public string 单位组 { get; set; }
        public string 主单位编号 { get; set; }
        public string 主单位 { get; set; }
        public string 辅单位编号 { get; set; }
        public string 辅单位 { get; set; }
        public decimal? 换算率 { get; set; }
        public string 登记人 { get; set; }
        public DateTime? 登记日期 { get; set; }
        public string 图形编号 { get; set; }
        public int? Length { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string 分类编号 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}

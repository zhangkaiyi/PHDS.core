using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsIdDel
    {
        public int StdId { get; set; }
        public string TheId { get; set; }
        public string Prefix { get; set; }
        public string Prefix1 { get; set; }
        public DateTime? Ymd { get; set; }
        public int? Yy { get; set; }
        public short? Mm { get; set; }
        public short? Dd { get; set; }
        public string RcId { get; set; }
    }
}

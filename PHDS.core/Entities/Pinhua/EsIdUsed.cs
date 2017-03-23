using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsIdUsed
    {
        public string TheId { get; set; }
        public int StdId { get; set; }
        public string SesId { get; set; }
        public string RcId { get; set; }
        public string WiId { get; set; }
        public short State { get; set; }
        public string Prefix { get; set; }
        public string Prefix1 { get; set; }
        public DateTime Ymd { get; set; }
        public short Yy { get; set; }
        public short Mm { get; set; }
        public short Dd { get; set; }
    }
}

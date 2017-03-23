using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUserDataFilter
    {
        public int UserId { get; set; }
        public string RtId { get; set; }
        public int TvType { get; set; }
        public int Dfid { get; set; }
        public string DataFilter { get; set; }
        public string FilterDesc { get; set; }
        public string FilterName { get; set; }
        public short DataType { get; set; }
        public int TId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsIdxTable
    {
        public int IdxId { get; set; }
        public int DtId { get; set; }
        public string IdxName { get; set; }
        public short IsClustered { get; set; }
        public short IsUnique { get; set; }
        public short IsIndex { get; set; }
    }
}

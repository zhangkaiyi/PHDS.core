using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDtDesignAcl
    {
        public int UserId { get; set; }
        public int DtId { get; set; }
        public short? Qry { get; set; }
        public short? Rewrite { get; set; }
        public short? Map { get; set; }
    }
}

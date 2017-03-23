using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpDesigner
    {
        public int UserId { get; set; }
        public string RtId { get; set; }
        public short Dgn { get; set; }
        public short Qry { get; set; }
        public short Rewrite { get; set; }
        public short Map { get; set; }
    }
}

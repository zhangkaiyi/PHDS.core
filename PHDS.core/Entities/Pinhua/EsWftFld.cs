using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWftFld
    {
        public int TId { get; set; }
        public int RtfId { get; set; }
        public short Editable { get; set; }
        public short Hidden { get; set; }
        public string AutoCommitData { get; set; }
        public string RecAuthDisp { get; set; }
        public string RecAuth { get; set; }
        public short DelData { get; set; }
    }
}

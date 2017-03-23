using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsIdRule
    {
        public int StdId { get; set; }
        public string Pattern { get; set; }
        public string Sample { get; set; }
        public short Reuse { get; set; }
        public short GenAtSave { get; set; }
    }
}

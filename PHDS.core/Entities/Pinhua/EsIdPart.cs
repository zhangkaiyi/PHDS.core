using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsIdPart
    {
        public int StdId { get; set; }
        public short No { get; set; }
        public short? PartType { get; set; }
        public short? SysVar { get; set; }
        public short? YmdStyle { get; set; }
        public string FixText { get; set; }
        public short? NumLen { get; set; }
        public int PartId { get; set; }
    }
}

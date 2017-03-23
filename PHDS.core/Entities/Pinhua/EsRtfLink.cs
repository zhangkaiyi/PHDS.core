using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRtfLink
    {
        public int RtfId { get; set; }
        public short No { get; set; }
        public string RtId { get; set; }
        public string Url { get; set; }
        public string Para { get; set; }
        public short EditMode { get; set; }
        public short LinkIgnoreFill { get; set; }
    }
}

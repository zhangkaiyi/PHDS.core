using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRtts
    {
        public int RttId { get; set; }
        public string RtId { get; set; }
        public short SheetId { get; set; }
        public int DtId { get; set; }
        public short OccurNo { get; set; }
        public short Style { get; set; }
        public short Extendable { get; set; }
        public short Extendable1 { get; set; }
        public short IfHidden { get; set; }
        public short Num { get; set; }
        public string Alias { get; set; }
    }
}

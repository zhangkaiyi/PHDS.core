using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpSheet
    {
        public string RtId { get; set; }
        public short SheetId { get; set; }
        public string SheetNo { get; set; }
        public string SheetName { get; set; }
        public int R1 { get; set; }
        public int C1 { get; set; }
        public int Rn { get; set; }
        public int Cn { get; set; }
        public short IfProtect { get; set; }
    }
}

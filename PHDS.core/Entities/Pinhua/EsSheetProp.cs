using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsSheetProp
    {
        public string RtId { get; set; }
        public short SheetId { get; set; }
        public int PropType { get; set; }
        public string PropName { get; set; }
        public string PropValue1 { get; set; }
        public string PropValue2 { get; set; }
        public string DisplayValue { get; set; }
    }
}

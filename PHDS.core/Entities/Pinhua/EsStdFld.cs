using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsStdFld
    {
        public int FldId { get; set; }
        public int StdId { get; set; }
        public short Op { get; set; }
        public short IsReturn { get; set; }
        public short OrdType { get; set; }
        public short GrpInList { get; set; }
        public short HiddenInList { get; set; }
        public string DispName { get; set; }
        public short Num { get; set; }
        public short IsFilter { get; set; }
        public int TreeId { get; set; }
        public int TreeFldId { get; set; }
        public short DispTotal { get; set; }
    }
}

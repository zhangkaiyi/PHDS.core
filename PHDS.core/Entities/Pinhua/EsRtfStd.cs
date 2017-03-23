using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRtfStd
    {
        public int StdId { get; set; }
        public int RtfId { get; set; }
        public int No { get; set; }
        public string OpCond { get; set; }
        public string Filter { get; set; }
        public string FilterSpec { get; set; }
        public string FilterSpecListGrp { get; set; }
        public short TreeSeparateFill { get; set; }
        public short ListMultiSel { get; set; }
        public string ListFill { get; set; }
        public short AutoIdGen { get; set; }
        public short NoBindNoId { get; set; }
        public short NewIdBindChg { get; set; }
        public short StdValRefresh { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRtfs
    {
        public int RtfId { get; set; }
        public string RtId { get; set; }
        public short SheetId { get; set; }
        public int? StdId { get; set; }
        public short OccurNo { get; set; }
        public int FldId { get; set; }
        public int RttId { get; set; }
        public short RtfNo { get; set; }
        public string DataRng { get; set; }
        public int Rf { get; set; }
        public int Rt { get; set; }
        public int Cf { get; set; }
        public int Ct { get; set; }
        public short IsIndex { get; set; }
        public string FullName { get; set; }
        public short NotNull { get; set; }
        public short IfHidden { get; set; }
        public short NoClear { get; set; }
        public short Locked { get; set; }
        public string FldAlias { get; set; }
        public string FldPrompt { get; set; }
        public short HeadMark { get; set; }
        public short OrdNo { get; set; }
        public short OrdType { get; set; }
        public short? GrpNo { get; set; }
        public short GrpOrdType { get; set; }
        public short LinkType { get; set; }
        public int LinkRtFld { get; set; }
        public string TreeFilter { get; set; }
        public string TreeFilterSpec { get; set; }
        public string ListGrpSpec { get; set; }
        public short TreeSeparateFill { get; set; }
        public short StdLstIsMultiSel { get; set; }
        public string ListFill { get; set; }
        public short Overprint { get; set; }
        public short NotPrint { get; set; }
        public short IsFindFld { get; set; }
        public short? LogUpd { get; set; }
        public short IsMerge { get; set; }
        public short InExprWfLink { get; set; }
        public short InExprTmpLock { get; set; }
        public short InExprTmpNotice { get; set; }
        public short StdValRefresh { get; set; }
        public short FldSpecial { get; set; }
        public short StdType { get; set; }
    }
}

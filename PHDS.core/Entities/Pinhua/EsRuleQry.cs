using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRuleQry
    {
        public string RuleId { get; set; }
        public int RttIdDest { get; set; }
        public string Sdts { get; set; }
        public string JoinCond { get; set; }
        public string InputVars { get; set; }
        public short IsDistinct { get; set; }
        public int TopN { get; set; }
        public short AppHide { get; set; }
        public short AppMenu { get; set; }
        public string ExecCondition { get; set; }
        public string ExecConSpec { get; set; }
        public short IfClearDataFld { get; set; }
        public short IfDelRow { get; set; }
        public short FillIfNotMatch { get; set; }
        public short FillAtTop { get; set; }
        public short IfReOrder { get; set; }
    }
}

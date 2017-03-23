using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRuleInsDetail
    {
        public string RuleId { get; set; }
        public string RtIdDest { get; set; }
        public int DtIdDest { get; set; }
        public string Matcher { get; set; }
        public short IsRollBack { get; set; }
    }
}

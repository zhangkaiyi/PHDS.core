using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRuleFill
    {
        public string RuleId { get; set; }
        public int RtfIdDest { get; set; }
        public string Expr { get; set; }
        public short Op { get; set; }
        public short Ord { get; set; }
        public short Num { get; set; }
        public short Locked { get; set; }
    }
}

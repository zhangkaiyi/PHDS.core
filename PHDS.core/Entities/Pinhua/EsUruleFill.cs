using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUruleFill
    {
        public string RuleId { get; set; }
        public int FldIdDest { get; set; }
        public string Expr { get; set; }
        public short IsUnique { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRules
    {
        public string RuleId { get; set; }
        public string RtId { get; set; }
        public string RuleName { get; set; }
        public string RuleDesc { get; set; }
        public short RuleType { get; set; }
        public string RuleSpec { get; set; }
        public short AppOrder { get; set; }
        public string Op { get; set; }
        public string FilterCond { get; set; }
        public short Dbtype { get; set; }
        public string TIds { get; set; }
        public DateTime? CreTime { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime? UpdTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public int Ver { get; set; }
        public short UseIsNull { get; set; }
    }
}

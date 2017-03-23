using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWftAuthScope
    {
        public int TId { get; set; }
        public short ScopeType { get; set; }
        public string RoleDisp { get; set; }
        public short ActorType { get; set; }
        public string Relation { get; set; }
        public int? RtfId { get; set; }
        public short RtfMeaning { get; set; }
    }
}

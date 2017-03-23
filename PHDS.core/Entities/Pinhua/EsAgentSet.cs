using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsAgentSet
    {
        public int UserId { get; set; }
        public short RevokeStyle { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? RevokeTime { get; set; }
        public short State { get; set; }
    }
}

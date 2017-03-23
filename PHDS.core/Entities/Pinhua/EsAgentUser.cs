using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsAgentUser
    {
        public int AgentUserId { get; set; }
        public int UserId { get; set; }
        public short TmpScope { get; set; }
        public string TmpIds { get; set; }
    }
}

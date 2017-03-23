using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsOuterLinkAcl
    {
        public int LinkId { get; set; }
        public int RoleId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
    }
}

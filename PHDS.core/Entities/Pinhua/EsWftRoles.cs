using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWftRoles
    {
        public int RoleId { get; set; }
        public int TId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
        public string DeptNames { get; set; }
    }
}

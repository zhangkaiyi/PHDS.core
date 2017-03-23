using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUserMgr
    {
        public int UserId { get; set; }
        public short MgrType { get; set; }
        public int? RoleId { get; set; }
        public int? DeptId { get; set; }
        public int? MgrId { get; set; }
    }
}

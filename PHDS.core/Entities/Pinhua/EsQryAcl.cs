using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsQryAcl
    {
        public int StdId { get; set; }
        public int RoleId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
        public short R { get; set; }
        public short Export { get; set; }
        public int UserId { get; set; }
        public short AuthType { get; set; }
    }
}

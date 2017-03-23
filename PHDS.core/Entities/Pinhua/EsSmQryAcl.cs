using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsSmQryAcl
    {
        public int CmdId { get; set; }
        public int RoleId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
    }
}

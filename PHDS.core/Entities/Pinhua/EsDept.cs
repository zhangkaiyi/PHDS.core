using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDept
    {
        public int DeptId { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public int? SuperId { get; set; }
        public string Path { get; set; }
        public string DispName { get; set; }
        public string FullName { get; set; }
        public short IsOrg { get; set; }
        public short IsOuter { get; set; }
        public string AdminName { get; set; }
    }
}

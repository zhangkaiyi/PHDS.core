using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpAcl
    {
        public int AuthId { get; set; }
        public short AuthType { get; set; }
        public int? UserId { get; set; }
        public string RtId { get; set; }
        public int? RepId { get; set; }
        public int? RoleId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
        public short C { get; set; }
        public short U { get; set; }
        public short D { get; set; }
        public short R { get; set; }
        public short ReadScope { get; set; }
        public short PartinProc { get; set; }
        public short FillbySub { get; set; }
        public short FillBySuper { get; set; }
        public short SelfUpd { get; set; }
        public short Prt { get; set; }
        public short SaveLocal { get; set; }
        public short Export { get; set; }
        public string FillFlds { get; set; }
        public string HiddenFlds { get; set; }
        public string ByFlds { get; set; }
        public string ExpDesc { get; set; }
        public string ExpSpec { get; set; }
        public short Lock { get; set; }
        public short Unlock { get; set; }
    }
}

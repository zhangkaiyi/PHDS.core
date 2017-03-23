using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public short BuiltIn { get; set; }
        public int BuiltinId { get; set; }
        public int CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime CreTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public DateTime UpdTime { get; set; }
        public short OtherCanUpd { get; set; }
        public short CanAssign { get; set; }
        public short HasSuper { get; set; }
        public int? SuperRoleId { get; set; }
        public string SuperRoleName { get; set; }
        public short SuperDeptType { get; set; }
        public int? SuperDeptId { get; set; }
        public string RoleSpec { get; set; }
        public short DeptScope { get; set; }
    }
}

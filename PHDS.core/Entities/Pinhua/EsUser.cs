using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUser
    {
        public int UserId { get; set; }
        public short Utype { get; set; }
        public short BuiltIn { get; set; }
        public int DeptId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string DispName { get; set; }
        public string UserLogin { get; set; }
        public string UserPwd { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public DateTime PwdDate { get; set; }
        public short AccState { get; set; }
        public short RegState { get; set; }
        public DateTime? LockDate { get; set; }
        public string Domain { get; set; }
        public string LdDn { get; set; }
        public string IpList { get; set; }
        public short SynLogin { get; set; }
        public short IsOuter { get; set; }
        public string Ocompany { get; set; }
        public string Oaddress { get; set; }
        public string Ozipcode { get; set; }
        public string Otelephone { get; set; }
        public short PwdNoChange { get; set; }
        public short UseOtpauth { get; set; }
        public string OtptokenId { get; set; }
        public short NoAgent { get; set; }
        public string ImId { get; set; }
        public string ImSignature { get; set; }
        public string AddPwd { get; set; }
        public string RoleNames { get; set; }
    }
}

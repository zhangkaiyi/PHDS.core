using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUserRegInfo
    {
        public int UserId { get; set; }
        public short IsOuter { get; set; }
        public DateTime RegTime { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPwd { get; set; }
        public string DeptName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Telephone { get; set; }
        public string UserDesc { get; set; }
        public short RegState { get; set; }
        public DateTime? DealTime { get; set; }
        public string NoPassReason { get; set; }
    }
}

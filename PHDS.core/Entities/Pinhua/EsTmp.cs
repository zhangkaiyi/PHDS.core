using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmp
    {
        public string RtId { get; set; }
        public string RtNo { get; set; }
        public string RtName { get; set; }
        public short State { get; set; }
        public int? ClassId { get; set; }
        public DateTime CreTime { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime UpdTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public short QryOnly { get; set; }
        public short IfCheckout { get; set; }
        public int? CheckoutBy { get; set; }
        public string CheckoutByName { get; set; }
        public short ProtectType { get; set; }
        public string RtPwd { get; set; }
        public short IfLockByExp { get; set; }
        public string LockExpText { get; set; }
        public string LockExpSpec { get; set; }
        public short LockDependDate { get; set; }
        public short IfMakeWeb { get; set; }
        public int Ver { get; set; }
        public short IndexType { get; set; }
        public string IndexDesc { get; set; }
        public string IndexSpec { get; set; }
        public short HasNoticeExp { get; set; }
        public short FileFormat { get; set; }
    }
}

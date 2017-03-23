using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDataDomain
    {
        public string DomainName { get; set; }
        public int DomainId { get; set; }
        public short BaseType { get; set; }
        public string InnerType { get; set; }
        public short? L { get; set; }
        public short? D { get; set; }
        public string Remark { get; set; }
        public string MatchPattern { get; set; }
        public short PreDefined { get; set; }
        public string DftName { get; set; }
        public string DftValue { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public DateTime? UpdTime { get; set; }
        public short OtherCanUpd { get; set; }
        public short IsIdentity { get; set; }
        public short IsUrl { get; set; }
    }
}

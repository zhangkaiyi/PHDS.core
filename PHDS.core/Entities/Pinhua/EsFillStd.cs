using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsFillStd
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public short StdType { get; set; }
        public short BuiltIn { get; set; }
        public short BuiltInId { get; set; }
        public short DsType { get; set; }
        public int? DtId { get; set; }
        public string Filter { get; set; }
        public string Expr { get; set; }
        public short Mia { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime? CreTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public DateTime? UpdTime { get; set; }
        public short OtherCanUpd { get; set; }
        public string GrpExpr { get; set; }
        public short UseIsNull { get; set; }
    }
}

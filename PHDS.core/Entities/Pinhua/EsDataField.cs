using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDataField
    {
        public int FldId { get; set; }
        public string DataType { get; set; }
        public int DtId { get; set; }
        public string FldName { get; set; }
        public short FldNo { get; set; }
        public short BaseType { get; set; }
        public string InnerType { get; set; }
        public short IsIdentity { get; set; }
        public short NotNull { get; set; }
        public string RealName { get; set; }
        public short? IfPk { get; set; }
        public int? IdxId { get; set; }
        public string PicType { get; set; }
        public short L { get; set; }
        public string Expr { get; set; }
    }
}

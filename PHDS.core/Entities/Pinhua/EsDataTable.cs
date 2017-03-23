using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDataTable
    {
        public int DtId { get; set; }
        public int? DsId { get; set; }
        public string DtName { get; set; }
        public string DsName { get; set; }
        public short State { get; set; }
        public DateTime? CreDate { get; set; }
        public string RealName { get; set; }
        public string Schem { get; set; }
        public string Catalog { get; set; }
        public string RefName { get; set; }
        public short IsView { get; set; }
        public string RefNameBak { get; set; }
        public short IfReadOnly { get; set; }
        public short IfCanMap { get; set; }
        public short BuiltIn { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public DateTime? UpdTime { get; set; }
    }
}

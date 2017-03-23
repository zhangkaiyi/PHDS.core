using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsStdQry
    {
        public int StdId { get; set; }
        public int? ClassId { get; set; }
        public short HasGrp { get; set; }
        public string QryNo { get; set; }
        public short AutoRmd { get; set; }
        public int TaskId { get; set; }
        public short RmdByIm { get; set; }
        public short RmdByEmail { get; set; }
        public short RmdBySm { get; set; }
        public short RmdCon { get; set; }
    }
}

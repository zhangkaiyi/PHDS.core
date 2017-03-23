using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDataRef
    {
        public short ObjType { get; set; }
        public string ObjId { get; set; }
        public short RefType { get; set; }
        public string RefId { get; set; }
        public string MainRefId { get; set; }
    }
}

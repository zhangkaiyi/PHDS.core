using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsVirtualWi
    {
        public string WiId { get; set; }
        public short WiType { get; set; }
        public short SubWiNum { get; set; }
        public short SubWiComp { get; set; }
        public short State { get; set; }
    }
}

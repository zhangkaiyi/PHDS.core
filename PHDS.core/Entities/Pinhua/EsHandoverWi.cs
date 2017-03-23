using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsHandoverWi
    {
        public string Hid { get; set; }
        public string WiId { get; set; }
        public short CreBy { get; set; }
        public short? ComBy { get; set; }
        public short Todo { get; set; }
    }
}

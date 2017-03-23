using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWfCase
    {
        public string PiId { get; set; }
        public int PId { get; set; }
        public DateTime InitDate { get; set; }
        public int InitUser { get; set; }
        public short? State { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsStdList
    {
        public int StdId { get; set; }
        public short HasGrp { get; set; }
        public short IsDistinct { get; set; }
        public short ShowByFilter { get; set; }
        public short NoPage { get; set; }
    }
}

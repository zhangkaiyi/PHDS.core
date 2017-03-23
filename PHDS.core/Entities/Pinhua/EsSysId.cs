using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsSysId
    {
        public int IdName { get; set; }
        public int MaxId { get; set; }
        public DateTime MaxDate { get; set; }
        public short NoNum { get; set; }
        public string Prefix { get; set; }
        public string IdDesc { get; set; }
    }
}

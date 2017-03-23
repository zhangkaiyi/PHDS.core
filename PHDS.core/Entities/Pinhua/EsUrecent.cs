using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUrecent
    {
        public int UserId { get; set; }
        public string RecType { get; set; }
        public int RecNo { get; set; }
        public string Pk1 { get; set; }
        public DateTime? RecTime { get; set; }
    }
}

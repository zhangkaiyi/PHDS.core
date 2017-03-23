using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsStdValSet
    {
        public int StdId { get; set; }
        public int Vno { get; set; }
        public string Value { get; set; }
        public string K { get; set; }
        public string Fk { get; set; }
    }
}

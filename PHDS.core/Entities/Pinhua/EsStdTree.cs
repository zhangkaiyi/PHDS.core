using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsStdTree
    {
        public int StdId { get; set; }
        public short LeafOnly { get; set; }
        public short MultiSelect { get; set; }
        public short Style { get; set; }
        public string KeyLen { get; set; }
        public short OrdBy { get; set; }
        public short Ord { get; set; }
    }
}

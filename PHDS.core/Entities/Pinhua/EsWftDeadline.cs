using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWftDeadline
    {
        public int TId { get; set; }
        public short IfDeadLine { get; set; }
        public short TdUnit { get; set; }
        public int? TdNum { get; set; }
        public short? DlDay { get; set; }
        public short? DlWk { get; set; }
        public DateTime? DlTime { get; set; }
        public short IfRemind { get; set; }
        public short RmdUnit { get; set; }
        public int? RmdNum { get; set; }
        public short ReUnit { get; set; }
        public int? ReNum { get; set; }
        public short AutoCommit { get; set; }
    }
}

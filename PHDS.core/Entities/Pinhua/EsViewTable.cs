using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsViewTable
    {
        public int DtId { get; set; }
        public short DirectSql { get; set; }
        public string SelectStmt { get; set; }
        public string CreateStmt { get; set; }
        public string ViewDesc { get; set; }
        public string BaseTables { get; set; }
        public string JoinCond { get; set; }
        public string Filter { get; set; }
        public short UseIsNull { get; set; }
    }
}

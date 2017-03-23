using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsDataSource
    {
        public int DsId { get; set; }
        public string DsName { get; set; }
        public short DsType { get; set; }
        public short DbmsType { get; set; }
        public string DataSrc { get; set; }
        public int? Port { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string Db { get; set; }
        public string LnkServerName { get; set; }
        public short SubType { get; set; }
        public short SupportTrans { get; set; }
        public DateTime CreTime { get; set; }
        public short State { get; set; }
    }
}

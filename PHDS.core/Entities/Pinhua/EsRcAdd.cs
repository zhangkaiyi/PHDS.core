using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRcAdd
    {
        public string RcId { get; set; }
        public byte[] XlsFile { get; set; }
        public string FileType { get; set; }
        public short SaveInto { get; set; }
        public int? NfsfolderId { get; set; }
        public string Nfsfolder { get; set; }
        public string RelaFolder { get; set; }
        public string PhyFileName { get; set; }
    }
}

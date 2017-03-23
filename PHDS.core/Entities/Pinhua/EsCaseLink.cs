using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsCaseLink
    {
        public string RcId { get; set; }
        public string LinkNo { get; set; }
        public byte[] Data { get; set; }
        public string FileType { get; set; }
        public int RtfId { get; set; }
        public int Sh { get; set; }
        public int R { get; set; }
        public int C { get; set; }
        public short IsNew { get; set; }
        public string Display { get; set; }
        public string FileName { get; set; }
        public string Rng { get; set; }
        public short SaveInto { get; set; }
        public int? NfsfolderId { get; set; }
        public string Nfsfolder { get; set; }
        public string RelaFolder { get; set; }
        public string PhyFileName { get; set; }
    }
}

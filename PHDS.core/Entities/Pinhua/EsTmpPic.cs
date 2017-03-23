using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpPic
    {
        public string PicNo { get; set; }
        public string RtId { get; set; }
        public byte[] Img { get; set; }
        public string FileType { get; set; }
        public short UseType { get; set; }
        public decimal H { get; set; }
        public decimal W { get; set; }
        public decimal L { get; set; }
        public decimal T { get; set; }
        public int Sh { get; set; }
        public int R { get; set; }
        public int C { get; set; }
        public short IsNew { get; set; }
        public short IsMove { get; set; }
    }
}

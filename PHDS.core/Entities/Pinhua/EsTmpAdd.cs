using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpAdd
    {
        public string RtId { get; set; }
        public byte[] TmpFile { get; set; }
        public byte[] Css { get; set; }
    }
}

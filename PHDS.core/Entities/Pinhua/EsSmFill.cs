using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsSmFill
    {
        public int CmdId { get; set; }
        public string RtId { get; set; }
        public string Spec { get; set; }
        public string SepaT { get; set; }
        public string SepaR { get; set; }
        public string SepaF { get; set; }
    }
}

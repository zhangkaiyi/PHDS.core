using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsImmsgLog
    {
        public DateTime SendTime { get; set; }
        public string SenderName { get; set; }
        public int Recver { get; set; }
        public int? Sender { get; set; }
        public short MsgType { get; set; }
        public string Content { get; set; }
        public string RecverName { get; set; }
    }
}

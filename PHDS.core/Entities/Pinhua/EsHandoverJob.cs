using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsHandoverJob
    {
        public string Hid { get; set; }
        public int FromUserId { get; set; }
        public string FromUserName { get; set; }
        public int ToUserId { get; set; }
        public string ToUserName { get; set; }
        public string RtId { get; set; }
        public DateTime HTime { get; set; }
    }
}

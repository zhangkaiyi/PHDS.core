using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsOuterLink
    {
        public int LinkId { get; set; }
        public int? ClassId { get; set; }
        public string LinkName { get; set; }
        public string LinkDesc { get; set; }
        public string Url { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime CreTime { get; set; }
        public short IfShow { get; set; }
        public short IfOpen { get; set; }
        public string Paras { get; set; }
    }
}

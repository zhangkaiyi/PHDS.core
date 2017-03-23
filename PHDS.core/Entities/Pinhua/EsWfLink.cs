using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWfLink
    {
        public int RouteId { get; set; }
        public int PId { get; set; }
        public int TId { get; set; }
        public int TtId { get; set; }
        public short HasExp { get; set; }
        public string ExpDesc { get; set; }
        public string ExpSpec { get; set; }
        public short JointType { get; set; }
        public int? JointNum { get; set; }
        public short JointNumType { get; set; }
        public string ShapeName { get; set; }
        public string Rtfs { get; set; }
    }
}

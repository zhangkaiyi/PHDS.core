using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpClass
    {
        public int ClassId { get; set; }
        public int? SuperId { get; set; }
        public string ClassName { get; set; }
        public short OrdNum { get; set; }
        public string OrdPath { get; set; }
        public string Path { get; set; }
        public string FullName { get; set; }
        public int? CreUid { get; set; }
        public string CreUname { get; set; }
        public DateTime CreTime { get; set; }
        public int? UpdUid { get; set; }
        public string UpdUname { get; set; }
        public DateTime UpdTime { get; set; }
        public short OtherCanUpd { get; set; }
    }
}

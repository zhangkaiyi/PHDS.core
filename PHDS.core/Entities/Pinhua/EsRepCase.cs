using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsRepCase
    {
        public string RcId { get; set; }
        public string RtId { get; set; }
        public int? FillDept { get; set; }
        public string FillDeptName { get; set; }
        public int? FillUser { get; set; }
        public string FillUserName { get; set; }
        public DateTime FillDate { get; set; }
        public string RcDesc { get; set; }
        public short? State { get; set; }
        public int LstFiller { get; set; }
        public string LstFillerName { get; set; }
        public DateTime LstFillDate { get; set; }
        public short BackUpdate { get; set; }
        public short OpenState { get; set; }
        public int? OpenBy { get; set; }
        public string OpenByName { get; set; }
        public string OpenBySesId { get; set; }
        public short LockState { get; set; }
        public short LockInServer { get; set; }
        public short NoticeState { get; set; }
        public short SetNstateInServer { get; set; }
        public int? ReplacerIdFill { get; set; }
        public string ReplacerNameFill { get; set; }
        public int? ReplacerIdLstFill { get; set; }
        public string ReplacerNameLstFill { get; set; }
        public DateTime? PrintTime { get; set; }
        public string WiId { get; set; }
        public short CommitByDataWriter { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWfTask
    {
        public int TId { get; set; }
        public int PId { get; set; }
        public short TType { get; set; }
        public string RtId { get; set; }
        public string TName { get; set; }
        public string TDesc { get; set; }
        public string ShapeName { get; set; }
        public short Flag { get; set; }
        public short IfReadOnly { get; set; }
        public short IfSendSms { get; set; }
        public short IfSendEmail { get; set; }
        public short CanReturn { get; set; }
        public int? PIdNew { get; set; }
        public string RtIdNew { get; set; }
        public int? TIdNew { get; set; }
        public short JointType { get; set; }
        public int? JointNum { get; set; }
        public short JointNumType { get; set; }
        public short IfJointData { get; set; }
        public short QuickOpen { get; set; }
        public string SaveCaption { get; set; }
        public string SavePrompt { get; set; }
        public short DelFlag { get; set; }
        public short CommitByDataWriter { get; set; }
        public short LogoutAfterCommit { get; set; }
        public short SaveRetData { get; set; }
        public short BackData { get; set; }
        public short NoTempSave { get; set; }
    }
}

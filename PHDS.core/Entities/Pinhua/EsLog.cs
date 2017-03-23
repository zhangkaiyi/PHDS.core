using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsLog
    {
        public string LogId { get; set; }
        public string SesId { get; set; }
        public short LogType { get; set; }
        public DateTime OpTime { get; set; }
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Computer { get; set; }
        public string Ip { get; set; }
        public string FuncName { get; set; }
        public string OpDesc { get; set; }
        public string RtId { get; set; }
        public string RcId { get; set; }
        public string WiId { get; set; }
        public short AppNo { get; set; }
        public int? AgentId { get; set; }
        public string AgentLogin { get; set; }
        public string AgentName { get; set; }
        public string SqlStmt { get; set; }
    }
}

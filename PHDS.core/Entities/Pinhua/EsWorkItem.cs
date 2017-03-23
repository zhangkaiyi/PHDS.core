using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsWorkItem
    {
        public string WiId { get; set; }
        public string RcId { get; set; }
        public int TId { get; set; }
        public string PiId { get; set; }
        public short WiType { get; set; }
        public short State { get; set; }
        public int? CreBy { get; set; }
        public string CreByName { get; set; }
        public int? CreByA { get; set; }
        public string CreByNameA { get; set; }
        public DateTime? CreDate { get; set; }
        public DateTime? DlDate { get; set; }
        public string WiDesc { get; set; }
        public int? ComBy { get; set; }
        public string ComByName { get; set; }
        public int? ComByA { get; set; }
        public string ComByNameA { get; set; }
        public DateTime? ComDate { get; set; }
        public int? CheckOutBy { get; set; }
        public string CheckOutByName { get; set; }
        public string CheckoutBySesId { get; set; }
        public short State1 { get; set; }
        public int? RtnBy { get; set; }
        public string RtnByName { get; set; }
        public DateTime? RtnTime { get; set; }
        public DateTime? RmdTime { get; set; }
        public short IsFirst { get; set; }
        public short Temp1 { get; set; }
        public short AutoCommit { get; set; }
    }
}

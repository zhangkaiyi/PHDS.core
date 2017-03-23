using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsHomeInfo
    {
        public int Id { get; set; }
        public DateTime UpdTime { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebUrl { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string TaxNo { get; set; }
        public string JPerson { get; set; }
        public short? AcctDay { get; set; }
        public short? AcctTime { get; set; }
        public string CaseDesc { get; set; }
        public string Dbname { get; set; }
        public short DomainUser { get; set; }
        public short RoleGrp { get; set; }
        public short AllowOuter { get; set; }
        public short AutoRegUser { get; set; }
        public string RegPrompt { get; set; }
        public string EmailContent { get; set; }
        public short AllowSendEmail { get; set; }
        public string EmailSubject { get; set; }
        public string EmailPcontent { get; set; }
        public string EmailRcontent { get; set; }
        public short Ldenable { get; set; }
        public string Ldhost { get; set; }
        public int? Ldport { get; set; }
        public string LdbaseDn { get; set; }
        public string LdbindDn { get; set; }
        public string Ldpasswd { get; set; }
        public string AttLimit { get; set; }
        public short MenuStyle { get; set; }
        public short HideHead { get; set; }
        public short HideGridline { get; set; }
        public short HideEditbox { get; set; }
        public string Version { get; set; }
        public int AppId { get; set; }
        public short FillSecurity { get; set; }
        public short AcctMonthType { get; set; }
        public short AcctMonth { get; set; }
        public short WfConExec { get; set; }
        public string AppTitle { get; set; }
        public string AppWindowCaption { get; set; }
    }
}

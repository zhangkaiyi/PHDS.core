using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUserOption
    {
        public int UserId { get; set; }
        public string DftRtId { get; set; }
        public short DftWin { get; set; }
        public short MoveDirect { get; set; }
        public short UseDateObj { get; set; }
        public short UseTreeObj { get; set; }
        public short TimeOnWork { get; set; }
        public short TimeOnReport { get; set; }
        public string ShowField { get; set; }
        public short QryAutoFill { get; set; }
        public short UseSms { get; set; }
        public short MenuStyle { get; set; }
        public short HideHead { get; set; }
        public short HideGridline { get; set; }
        public short HideEditBox { get; set; }
        public short WaQuicken { get; set; }
        public short ExitOnNewLogin { get; set; }
        public short ShowDoneWi { get; set; }
        public short WiDateUnit { get; set; }
        public short WiDateNum { get; set; }
        public short MultiPage { get; set; }
        public int PageSize { get; set; }
    }
}

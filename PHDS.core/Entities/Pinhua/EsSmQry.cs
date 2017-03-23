using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsSmQry
    {
        public int CmdId { get; set; }
        public string QryParams { get; set; }
        public string RtnSyntax { get; set; }
        public string Datasrc { get; set; }
        public string JoinCond { get; set; }
        public string Filter { get; set; }
        public string FillManner { get; set; }
        public string QryDesc { get; set; }
        public string QrySpec { get; set; }
    }
}

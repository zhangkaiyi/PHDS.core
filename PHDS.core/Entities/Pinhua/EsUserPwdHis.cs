using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsUserPwdHis
    {
        public int UserId { get; set; }
        public DateTime CreTime { get; set; }
        public string Pwd { get; set; }
    }
}

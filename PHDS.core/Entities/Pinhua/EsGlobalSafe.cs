using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsGlobalSafe
    {
        public int Id { get; set; }
        public short PwdMinLen { get; set; }
        public short PwdMaxDay { get; set; }
        public string PwdCharset { get; set; }
        public string SpecialChars { get; set; }
        public short PwdCycle { get; set; }
        public short PwdLockExp { get; set; }
        public short PwdErrTimes { get; set; }
        public short AwakeLoginA { get; set; }
        public int LoginSleepMn { get; set; }
        public short AwakeLoginM { get; set; }
        public string TmpProtectPwd { get; set; }
        public short AssRwscope { get; set; }
        public short AssRwdeptSet { get; set; }
        public short AssRwroleSet { get; set; }
        public short AssDgnScope { get; set; }
        public short AssDgnDeptSet { get; set; }
        public short AssDgnRoleSet { get; set; }
        public short AssExcludeAdmin { get; set; }
        public short DirectSql { get; set; }
    }
}

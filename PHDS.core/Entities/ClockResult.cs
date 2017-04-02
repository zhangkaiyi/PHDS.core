using PHDS.core.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Entities
{
    public class ClockResult
    {
        public ClockResultEnum Result { get; set; }
        public ClockType Type { get; set; }
        public double Minute { get; set; }

        public string RangeName { get; set; }
    }

    public enum ClockResultEnum
    {
        迟到,
        早退,
        提前,
        延迟,
    }
}

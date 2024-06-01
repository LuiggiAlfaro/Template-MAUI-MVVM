using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.UI.Models
{
    public class TimerModel
    {
        public TimeSpan StartTime { get; set; }
        public int Interval { get; set; }
        public string AudioFile { get; set; }
        public string Countdown { get; set; }
    }
}

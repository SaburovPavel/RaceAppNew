using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class Race
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeNow { get; set; }
        public DateTime TimeFromStart { get; set; }
        public DateTime TimeLap { get; set; }
        public DateTime TimePenalty { get; set; }
        public DateTime TimePlusPenalty { get; set; }
        public int Lap { get; set; }
        public string Place { get; set; }
        public string FinDnf { get; set; }
        public int Promah { get; set; }
        public bool SendToEmail { get; set; }
        public bool Stopped { get; set; }

        public virtual User User { get; set; }
    }
}

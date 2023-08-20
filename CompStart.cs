using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class CompStart
    {
        public int Id {  get; set; }
        public int CompId { get; set; }
        public int GroupId { get; set; }
        public int DistanceId { get; set; }
        public int? Lap { get; set; }
        public DateTime Time { get; set; }

        public virtual Comp Comp { get; set; }
        public virtual Group Group { get; set; }
        public virtual Distance Distance { get; set; }
    }
}

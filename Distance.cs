using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class Distance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? LenthLap { get; set; }
        public int? HighLap { get; set; }

        public virtual ICollection<CompStart> CompStarts { get; set;}
    }
}

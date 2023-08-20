using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class RaceTeam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Place { get; set; }
        public int Lap { get; set; }

        public virtual Team Team { get; set; }
    }
}

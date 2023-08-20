using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompId { get; set; }
        public int GroupId { get; set; }

        public virtual Comp Comp { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<RaceTeam> RaceTeams { get; set; }
    }
}

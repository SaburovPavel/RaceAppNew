using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class Group
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int AgeAt { get; set; }
        public int AgeTo { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public bool ForTeam { get; set; }

        public virtual ICollection<CompStart> CompStarts { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sourname { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int GroupId { get; set; }
        public int? StartNum { get; set; }
        public int? ChipNum { get; set; }
        public int CompId { get; set; }
        public int? TeamId { get; set; }
        public DateTime TimeStart { get; set;}
        public string SN { get; set;}
        
        public virtual Group Group { get; set; }
        public virtual Comp Comp { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Race> Races { get; set; }
        public virtual ICollection<PassChip> PassChips { get; set; }
    }
}

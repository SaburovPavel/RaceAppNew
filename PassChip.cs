using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class PassChip
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int CompId { get; set; }
        public bool Duplicate { get; set; }
        public bool Confirm { get; set; }

        public virtual User User { get; set; }
        public virtual Comp Comp { get; set; }
    }
}

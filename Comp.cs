using System;
using System.Collections;
using System.Collections.Generic;

namespace RaceApp
{
    public class Comp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Orbitr { get; set; }
        public string Organizer { get; set; }
        public DateTime Date { get; set; }
        public string Secretar { get; set; }
        public bool Individual { get; set; }
        public bool Biathlon { get; set; }
        public int? TimePenalty { get; set; }
        public int? TimeIntervalStart { get; set; }
        public string SN { get; set; }
        public int? TimeIntervalReadTag { get; set; }

        public virtual ICollection<CompStart> CompStarts { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<PassChip> PassChips { get; set; }
    }
}
 
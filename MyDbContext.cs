using System;
using System.Data.Entity;

namespace RaceApp
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext () : base("DBConnectionString")
        {

        }

        public DbSet<Comp> Comps { get; set; }
        public DbSet<CompStart> CompsStarts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<EmailToSend> EmailToSends { get; set; }
        public DbSet<PassChip> PassChips { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceTeam> RaceTeams { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using night_life_sk.Models;
using System.Diagnostics.Metrics;

namespace night_life_sk.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<PartyPlace> PartyPlaces { get; set; }
        public DbSet<PartyEvent> PartyEvents { get; set; }

    }
}

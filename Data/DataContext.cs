using Microsoft.EntityFrameworkCore;
using night_life_sk.Models;

namespace night_life_sk.Data
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        internal DbSet<AppUser> AppUsers { get; set; }
        internal DbSet<PartyPlace> PartyPlaces { get; set; }
        internal DbSet<PartyEvent> PartyEvents { get; set; }

    }
}

using night_life_sk.Services.persistence;

namespace night_life_sk.Models
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public HashSet<PartyPlace>? PartyPlaces { get; set;}
    }
}

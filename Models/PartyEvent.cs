using night_life_sk.Services.persistence;

namespace night_life_sk.Models
{
    public class PartyEvent : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime EventTime { get; set; }
        public virtual PartyPlace? PartyPlace { get; set; }
        public virtual HashSet<AppUser>? AppUsers { get; set; }

        public PartyEvent()
        {
            Name = string.Empty;
            Description = string.Empty;
            Genre = string.Empty;
            ImageUrl = string.Empty;
        }

        public PartyEvent(string name, string description, string genre, int price, string imageUrl, DateTime time) 
        {
            Name = name;
            Description = description;
            Genre = genre;
            Price = price;
            ImageUrl = imageUrl;
            EventTime = time;
        }
    }
}

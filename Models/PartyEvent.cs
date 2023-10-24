namespace night_life_sk.Models
{
    internal class PartyEvent : IEntity
    {
        public int Id { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal string Genre { get; set; }
        internal int Price { get; set; }
        internal string ImageUrl { get; set; }
        internal DateTime EventTime { get; set; }
        internal virtual PartyPlace PartyPlace { get; set; }
        internal virtual HashSet<AppUser>? AppUsers { get; set; }

        public PartyEvent()
        {
            PartyPlace = new PartyPlace();
            Name = string.Empty;
            Description = string.Empty;
            Genre = string.Empty;
            ImageUrl = string.Empty;
        }

        internal PartyEvent(string name, string description, string genre, int price, string imageUrl, DateTime time, PartyPlace partyPlace) 
        {
            PartyPlace = partyPlace;
            Name = name;
            Description = description;
            Genre = genre;
            Price = price;
            ImageUrl = imageUrl;
            EventTime = time;
        }
    }
}

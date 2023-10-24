namespace night_life_sk.Models
{
    internal class PartyPlace : IEntity
    {
        public int Id { get; set; }
        internal string Name { get; set; }
        internal string Address { get; set; }
        internal double Latitude { get; set; }
        internal double Longitude { get; set;}
        internal virtual AppUser? AppUser { get; set; }
        internal virtual HashSet<PartyEvent>? Events { get; set; }
        
        public PartyPlace() 
        {
            Name = string.Empty;
            Address = string.Empty;
            Latitude = 0.0;
            Longitude = 0.0;
        }

        internal PartyPlace(int id, string name, string address, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}

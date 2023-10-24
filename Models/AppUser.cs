
namespace night_life_sk.Models
{
    internal class AppUser : IEntity
    {
        public int Id { get; set; }
        internal string Username { get; set; }
        internal string Password { get; set; }
        internal string Email { get; set; }
        internal virtual HashSet<PartyPlace>? PartyPlaces { get; set;}

        public AppUser ()
        {
            Email = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
        }

        internal AppUser (string username, string password, string email)
        {
            Email = email;
            Username = username;
            Password = password;
        }
    }
}

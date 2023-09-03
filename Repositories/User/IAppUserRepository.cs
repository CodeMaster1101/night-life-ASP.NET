using night_life_sk.Models;

namespace night_life_sk.Repositories.user
{
    public interface IAppUserRepository
    {
        public void Add(AppUser appUser);

        public HashSet<AppUser> FindAll();

        public AppUser FindById(int id);

        public void Update(AppUser appUser);

        public void Delete(int id);
        public HashSet<AppUser> FindAllByPartyName(string eventName);
    }
}

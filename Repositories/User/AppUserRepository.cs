using night_life_sk.Models;
using night_life_sk.Services.persistence;

namespace night_life_sk.Repositories.user
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly EntityPersistenceService entityPersistenceService;
        public AppUserRepository(EntityPersistenceService entityPersistenceService)
        {
            this.entityPersistenceService = entityPersistenceService;
        }

        public void Add(AppUser appUser) => entityPersistenceService.Add(appUser);

        public HashSet<AppUser> FindAll() => entityPersistenceService.FindAll<AppUser>();  

        public AppUser FindById(int id) => entityPersistenceService.FindById<AppUser>(id);

        public void Update(AppUser appUser) => entityPersistenceService.Update(appUser);

        public void Delete(int id) => entityPersistenceService.Delete<AppUser>(id);

        public HashSet<AppUser> FindAllByPartyName(string eventName) => entityPersistenceService.FindAllGuestsByPartyName(eventName);
        
    }
}

using night_life_sk.Models;
using night_life_sk.Services.persistence;

namespace night_life_sk.Repositories
{
    internal class AppUserRepository
    {
        private readonly EntityPersistenceService entityPersistenceService;
        public AppUserRepository(EntityPersistenceService entityPersistenceService)
        {
            this.entityPersistenceService = entityPersistenceService;
        }

        internal async Task Add(AppUser appUser) => await entityPersistenceService.Add(appUser);

        internal async Task<List<AppUser>> FindAll() => await entityPersistenceService.FindAll<AppUser>();

        internal async Task<AppUser> FindById(int id) => await entityPersistenceService.FindById<AppUser>(id);

        internal async Task Update(AppUser appUser) =>  await entityPersistenceService.Update(appUser);

        internal async Task Delete(int id) =>  await entityPersistenceService.Delete<AppUser>(id);

        internal async Task<HashSet<AppUser>> FindAllByPartyName(string eventName) => 
            await entityPersistenceService.FindGuestByPartyName(eventName);

    }
}

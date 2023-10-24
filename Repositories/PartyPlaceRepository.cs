using night_life_sk.Models;
using night_life_sk.Services.persistence;

namespace night_life_sk.Repositories
{
    internal class PartyPlaceRepository
    {
        private readonly EntityPersistenceService entityPersistenceService;

        public PartyPlaceRepository(EntityPersistenceService entityPersistenceService)
        {
            this.entityPersistenceService = entityPersistenceService;
        }

        internal async Task Add(PartyPlace partyPlace) =>  await entityPersistenceService.Add(partyPlace);

        internal async Task Delete(int id) => await entityPersistenceService.Delete<PartyPlace>(id);

        internal async Task<List<PartyPlace>> FindAll() => await entityPersistenceService.FindAll<PartyPlace>();

        internal async Task<PartyPlace> FindById(int id) => await entityPersistenceService.FindById<PartyPlace>(id);

        internal async Task Update(PartyPlace partyPlace) => await entityPersistenceService.Update(partyPlace);

        internal async Task<PartyPlace> FindByXYTime(double longitude, double latitude, DateTime date) =>
            await entityPersistenceService.FindByXYTime(longitude, latitude, date);
    }
}

using Microsoft.EntityFrameworkCore;
using night_life_sk.Data;
using night_life_sk.Models;
using night_life_sk.Services;
using night_life_sk.Exceptions;
using night_life_sk.Services.persistence;
using night_life_sk.Dto.Place;

namespace night_life_sk.Repositories
{
    internal class PartyEventRepository
    {
        private readonly EntityPersistenceService entityPersistenceService;

        public PartyEventRepository(EntityPersistenceService entityPersistenceService)
        {
            this.entityPersistenceService = entityPersistenceService;
        }

        internal async Task Add(PartyEvent partyEvent) => await entityPersistenceService.Add(partyEvent);

        internal async Task<List<PartyEvent>> FindAll() => await entityPersistenceService.FindAll<PartyEvent>();

        internal async Task<PartyEvent> FindById(int id) => await entityPersistenceService.FindById<PartyEvent>(id);

        internal async Task Delete(int id) => await entityPersistenceService.Delete<PartyEvent>(id);

        internal async Task Update(PartyEvent partyEvent) => await entityPersistenceService.Update(partyEvent);

        internal async Task<List<PartyEvent>> FindAllEventsByDate(DateTime date) =>
            await entityPersistenceService.FindAllEventsByDate(date);

        internal async Task<List<PartyPlace>> FindAllFilteredEvents(FilteredEventsDto filteredEvents) =>
           await entityPersistenceService.FindAllFilteredEvents(filteredEvents);
    }
}

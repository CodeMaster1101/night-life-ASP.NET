using Microsoft.EntityFrameworkCore;
using night_life_sk.Data;
using night_life_sk.Models;
using night_life_sk.Services;
using night_life_sk.Exceptions;
using night_life_sk.Services.persistence;
using night_life_sk.Dto.Place;

namespace night_life_sk.Repositories.Event
{
    public class PartyEventRepository : IPartyEventRepository
    {
        private readonly EntityPersistenceService entityPersistenceService;

        public PartyEventRepository(EntityPersistenceService entityPersistenceService)
        {
            this.entityPersistenceService = entityPersistenceService;
        }

        public void Add(PartyEvent partyEvent) => entityPersistenceService.Add(partyEvent);

        public HashSet<PartyEvent> FindAll() => entityPersistenceService.FindAll<PartyEvent>();

        public PartyEvent FindById(int id) => entityPersistenceService.FindById<PartyEvent>(id);

        public void Delete(int id) => entityPersistenceService.Delete<PartyEvent>(id);

        public void Update(PartyEvent partyEvent) => entityPersistenceService.Update<PartyEvent>(partyEvent);
        
        public HashSet<PartyEvent> FindAllEventsByDate(DateTime date) =>
            entityPersistenceService.FindAllEventsByDate(date);

        HashSet<PartyEvent> IPartyEventRepository.FindAllFilteredEvents(FilteredEventsDto filteredEvents) =>
            entityPersistenceService.FindAllFilteredEvents(filteredEvents);
    }
}

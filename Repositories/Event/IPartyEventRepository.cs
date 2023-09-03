using night_life_sk.Dto.Place;
using night_life_sk.Models;

namespace night_life_sk.Repositories.Event
{
    public interface IPartyEventRepository
    {
        public void Add(PartyEvent partyEvent);

        public HashSet<PartyEvent> FindAll();

        public PartyEvent FindById(int id);

        public void Update(PartyEvent partyEvent);

        public void Delete(int id);

        HashSet<PartyEvent> FindAllEventsByDate(DateTime date);

        HashSet<PartyEvent> FindAllFilteredEvents(FilteredEventsDto filteredEvents);
    }
}

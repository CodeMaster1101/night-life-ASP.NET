using night_life_sk.Dto.Event;
using night_life_sk.Dto.Place;
using night_life_sk.Dto.User;
using night_life_sk.Mappers;
using night_life_sk.Repositories;

namespace night_life_sk.Services
{
    internal class BaseMapService
    {
        private readonly PartyPlaceRepository partyPlaceRepository;
        private readonly PartyEventRepository partyEventRepository;
        private readonly AppUserRepository appUserRepository;

        public BaseMapService(
            PartyPlaceRepository partyPlaceRepository,
            PartyEventRepository partyEventRepository,
            AppUserRepository appUserRepository) 
        {
            this.appUserRepository = appUserRepository;
            this.partyEventRepository = partyEventRepository;
            this.partyPlaceRepository = partyPlaceRepository;
        }

        internal async Task<HashSet<PlaceCoordinates>> GetAllPartyPlaces() => 
            await PartyPlaceMapper.ConvertAllToCoordinatesAsync(partyPlaceRepository.FindAll());

        internal async Task<HashSet<PartyEventDto>> GetEventsByDate(DateTime date) =>
            await PartyEventMapper.ConvertAllToDTOAsync(partyEventRepository.FindAllEventsByDate(date));

        internal async Task<HashSet<PlaceCoordinates>> GetFilteredEvents(FilteredEventsDto filteredEvents) =>
            await PartyPlaceMapper.ConvertAllToCoordinatesAsync(partyEventRepository.FindAllFilteredEvents(filteredEvents));

        internal async Task<HashSet<AppUserDto>> GetInterestedUsersForEvent(string eventName) =>
            await AppUserMapper.ConvertAllToDTOAsync(appUserRepository.FindAllByPartyName(eventName));

        internal async Task<PlaceAndEventDto> GetPlaceAndEventOnClick(double longitude, double latitude, DateTime date) =>
            await PartyPlaceMapper.ConvertToOnClickClubAsync(partyPlaceRepository.FindByXYTime(longitude, latitude, date));
    }
}

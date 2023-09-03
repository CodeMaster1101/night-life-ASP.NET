using Microsoft.AspNetCore.Mvc;
using night_life_sk.Dto.Event;
using night_life_sk.Dto.Place;
using night_life_sk.Dto.User;
using night_life_sk.Mappers;
using night_life_sk.Models;
using night_life_sk.Repositories.Event;
using night_life_sk.Repositories.place;
using night_life_sk.Repositories.user;

namespace night_life_sk.Services
{
    public class BaseMapService
    {
        private readonly IPartyPlaceRepository partyPlaceRepository;
        private readonly IPartyEventRepository partyEventRepository;
        private readonly IAppUserRepository appUserRepository;
        private readonly PartyEventMapper partyEventMapper;
        private readonly PartyPlaceMapper partyPlaceMapper;
        private readonly AppUserMapper appUserMapper;
        
        public BaseMapService(
            AppUserMapper appUserMapper,            
            PartyEventMapper eventMapper,
            PartyPlaceMapper partyPlaceMapper,
            IPartyPlaceRepository partyPlaceRepository,
            IPartyEventRepository partyEventRepository,
            IAppUserRepository appUserRepository) 
        {
            this.appUserRepository = appUserRepository;
            this.appUserMapper = appUserMapper;
            this.partyEventRepository = partyEventRepository;
            this.partyEventMapper = eventMapper;
            this.partyPlaceMapper = partyPlaceMapper;
            this.partyPlaceRepository = partyPlaceRepository;
        }

        internal HashSet<PlaceCoordinates> GetAllPartyPlaces() => 
            partyPlaceMapper.ConvertAllToCoordinates(partyPlaceRepository.FindAll());

        internal HashSet<PartyEventDto> GetEventsByDate(DateTime date) =>
            partyEventMapper.ConvertAllToDTO(partyEventRepository.FindAllEventsByDate(date));

        internal HashSet<PartyEventDto> GetFilteredEvents(FilteredEventsDto filteredEvents) =>
            partyEventMapper.ConvertAllToDTO(partyEventRepository.FindAllFilteredEvents(filteredEvents));

        internal HashSet<AppUserDto> GetInterestedUsersForEvent(string eventName) =>
            appUserMapper.ConvertAllToDTO(appUserRepository.FindAllByPartyName(eventName));

        internal PlaceAndEventDto GetPlaceAndEventOnClick(double longitude, double latitude, DateTime date) => 
            partyPlaceMapper.ConvertToOnClickClub(partyPlaceRepository.FindByXYTime(longitude, latitude, date));
    }
}

using Microsoft.AspNetCore.Mvc;
using night_life_sk.Dto.Place;
using night_life_sk.Mappers;
using night_life_sk.Repositories.place;

namespace night_life_sk.Services
{
    public class BaseMapService
    {
        private readonly IPartyPlaceRepository partyPlaceRepository;
        private readonly PartyPlaceMapper partyPlaceMapper;
        public BaseMapService(
            PartyPlaceMapper partyPlaceMapper,
            IPartyPlaceRepository partyPlaceRepository) 
        {
            this.partyPlaceMapper = partyPlaceMapper;
            this.partyPlaceRepository = partyPlaceRepository;
        }

        internal HashSet<PlaceCoordinates> GetAllPartyPlaces() => 
            partyPlaceMapper.ConvertAllToCoordinates(partyPlaceRepository.FindAll());

        internal IActionResult GetPlaceAndEventOnClick(double longitude, double latitude, DateTime date)
        {

            throw new NotImplementedException();
        }
    }
}

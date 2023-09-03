using night_life_sk.Dto.Place;
using night_life_sk.Models;

namespace night_life_sk.Mappers
{
    public class PartyPlaceMapper
    {
        private readonly PartyEventMapper eventMapper;
        public PartyPlaceMapper(PartyEventMapper eventMapper)
        {
            this.eventMapper = eventMapper;
        }

        private static PartyPlaceDto ConvertToDTO(PartyPlace partyPlace)
        {
            return new PartyPlaceDto(
                partyPlace.Name, 
                partyPlace.Address,
                partyPlace.Latitude, 
                partyPlace.Longitude);
        }

        private static PlaceCoordinates ConvertToCoordinates(PartyPlace partyPlace)
        {
            return new PlaceCoordinates(
                partyPlace.Name,
                partyPlace.Latitude,
                partyPlace.Longitude);
        }

        public HashSet<PlaceCoordinates> ConvertAllToCoordinates(HashSet<PartyPlace> partyPlaces)
        {
            return partyPlaces.Select(place => ConvertToCoordinates(place)).ToHashSet();
        }

        public HashSet<PartyPlaceDto> ConvertAllToDTO(HashSet<PartyPlace> partyPlaces)
        {
            return partyPlaces.Select(place => ConvertToDTO(place)).ToHashSet();
        }

        public PlaceAndEventDto ConvertToOnClickClub(PartyPlace partyPlace)
        {
            PartyEvent? partyEvent = null;
            if (partyPlace.Events != null)
            {
                partyEvent = partyPlace.Events.FirstOrDefault();
            }
            return new PlaceAndEventDto(
                partyPlace.Address,
                partyPlace.Name,
                partyEvent != null ? eventMapper.ConvertToDTO(partyEvent) : null);
        }
    }
}

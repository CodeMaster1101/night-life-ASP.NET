using night_life_sk.Dto.Place;
using night_life_sk.Models;

namespace night_life_sk.Mappers
{
    public class PartyPlaceMapper
    {
        private static PartyPlaceDto ConvertToDTO(PartyPlace partyPlace)
        {
            return new PartyPlaceDto
            {
                Name = partyPlace.Name,
                Address = partyPlace.Address,
                Latitude = partyPlace.Latitude,
                Longitude = partyPlace.Longitude,
            };
        }

        private static PlaceCoordinates ConvertToCoordinates(PartyPlace partyPlace)
        {
            return new PlaceCoordinates
            {
                 PlaceName = partyPlace.Name,
                 Latitude  = partyPlace.Latitude,
                 Longitude = partyPlace.Longitude
            };
        }

        public HashSet<PlaceCoordinates> ConvertAllToCoordinates(HashSet<PartyPlace> partyPlaces)
        {
            return partyPlaces.Select(place => ConvertToCoordinates(place)).ToHashSet();
        }

        public HashSet<PartyPlaceDto> ConvertAllToDTO(HashSet<PartyPlace> partyPlaces)
        {
            return partyPlaces.Select(place => ConvertToDTO(place)).ToHashSet();
        }
    }
}

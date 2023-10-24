using night_life_sk.Dto.Place;
using night_life_sk.Models;

namespace night_life_sk.Mappers
{
    internal static class PartyPlaceMapper
    {

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

        internal static async Task<HashSet<PlaceCoordinates>> ConvertAllToCoordinatesAsync(Task<List<PartyPlace>> partyPlaces)
        {
            var places = await partyPlaces;
            return places.Select(place => ConvertToCoordinates(place)).ToHashSet();
        }

        internal static HashSet<PartyPlaceDto> ConvertAllToDTO(HashSet<PartyPlace> partyPlaces)
        {
            return partyPlaces.Select(place => ConvertToDTO(place)).ToHashSet();
        }

        internal static async Task<PlaceAndEventDto> ConvertToOnClickClubAsync(Task<PartyPlace> partyPlace)
        {
            PartyEvent? partyEvent = null;
            var result = await partyPlace;
            if (result.Events != null)
            {
                partyEvent = result.Events.FirstOrDefault();
            }
            return new PlaceAndEventDto(
                result.Address,
                result.Name,
                partyEvent != null ? PartyEventMapper.ConvertToDTO(partyEvent) : null);
        }
    }
}

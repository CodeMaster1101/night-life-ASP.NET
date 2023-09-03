using night_life_sk.Dto.Event;
using night_life_sk.Models;

namespace night_life_sk.Mappers
{
    public class PartyEventMapper
    {
        public PartyEventDto ConvertToDTO(PartyEvent partyEvent) 
        {
            return new PartyEventDto(
                partyEvent.Name,
                partyEvent.Description,
                partyEvent.Genre,
                partyEvent.Price,
                partyEvent.ImageUrl,
                partyEvent.EventTime,
                partyEvent.PartyPlace?.Latitude,
                partyEvent.PartyPlace?.Longitude);
        }

        internal HashSet<PartyEventDto> ConvertAllToDTO(HashSet<PartyEvent> partyEvents) => 
            partyEvents.Select(e => ConvertToDTO(e)).ToHashSet();
    }
}

using night_life_sk.Dto.Event;

namespace night_life_sk.Dto.Place
{
    public record PlaceAndEventDto(string Name, string Address, PartyEventDto? EventDto);
}

using night_life_sk.Dto.Event;

namespace night_life_sk.Dto.Place
{
    internal record PlaceAndEventDto(string Name, string Address, PartyEventDto? EventDto);
}

namespace night_life_sk.Dto.Event
{
    public record PartyEventDto(
    string Name,
    string Description,
    string Genre,
    int Price,
    string ImageUrl,
    DateTime EventTime,
    double? Latitude,
    double? Longitude);
}

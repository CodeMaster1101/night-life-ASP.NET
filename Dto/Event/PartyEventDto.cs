namespace night_life_sk.Dto.Event
{
    internal record PartyEventDto(
    string Name,
    string Description,
    string Genre,
    int Price,
    string ImageUrl,
    DateTime EventTime,
    double? Latitude,
    double? Longitude);
}

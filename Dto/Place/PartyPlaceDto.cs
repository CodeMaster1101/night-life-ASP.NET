namespace night_life_sk.Dto.Place
{
    public record PartyPlaceDto
    {
        public string? Name { get; init; }
        public string? Address { get; init; }
        public double? Latitude { get; init; }
        public double? Longitude { get; init; }
    }
}

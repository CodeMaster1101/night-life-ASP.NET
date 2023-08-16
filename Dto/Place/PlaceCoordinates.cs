namespace night_life_sk.Dto.Place
{
    public record PlaceCoordinates
    {
        public string? PlaceName { get; set; }
        public double? Latitude { get; init; }
        public double? Longitude { get; init; }
    }
}

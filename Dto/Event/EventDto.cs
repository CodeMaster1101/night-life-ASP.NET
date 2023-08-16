namespace night_life_sk.Dto.Event
{
    public record EventDto
    {
        public string? Name { get; init; }
        public string? Description { get; init; }
        public string? Genre { get; init; }
        public double? Price { get; init; }
        public string? ImageUrl { get; init; }
        public DateTime? EventTime { get; init; }
    }
}

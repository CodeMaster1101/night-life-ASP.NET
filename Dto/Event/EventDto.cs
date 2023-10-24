namespace night_life_sk.Dto.Event
{
    internal record EventDto
    {
        internal string? Name { get; init; }
        internal string? Description { get; init; }
        internal string? Genre { get; init; }
        internal double? Price { get; init; }
        internal string? ImageUrl { get; init; }
        internal DateTime? EventTime { get; init; }
    }
}

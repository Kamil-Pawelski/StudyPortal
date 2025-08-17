namespace Domain.Entities.CardsSet;

public class CardsSetDTO
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required DateTime LastModificationTime { get; set; }
    public required DateTime LastOpened { get; set; }
}

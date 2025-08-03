using Domain.Entities.Cards;

namespace Domain.Entities.CardsSet;

public class CardSet
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required DateTime LastModificationTime { get; set; }

    public ICollection<Card> Cards { get; set; } = [];

}

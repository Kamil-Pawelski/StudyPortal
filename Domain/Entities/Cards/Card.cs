using Domain.Entities.CardsSet;
namespace Domain.Entities.Cards;

public class Card
{
    public required Guid Id { get; set; }
    public Guid? FlashCardsSetId { get; set; }
    public required string Word { get; set; }
    public required string Translation { get; set; }

    public ICollection<CardSet> CardsSets { get; set; } = [];
}

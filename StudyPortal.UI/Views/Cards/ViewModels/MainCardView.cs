using Domain.Entities.Cards;

public class MainCardView(IEnumerable<Card> cards)
{
    public IEnumerable<Card> Cards { get; set; } = cards;
}
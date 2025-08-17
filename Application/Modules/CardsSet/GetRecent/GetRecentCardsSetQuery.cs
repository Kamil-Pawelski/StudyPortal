using Application.Abstractions.Messaging;
using Domain.Entities.CardsSet;

namespace Application.Modules.CardsSet.GetRecent;

public record GetRecentCardsSetQuery : IQuery<List<CardsSetDTO>>;


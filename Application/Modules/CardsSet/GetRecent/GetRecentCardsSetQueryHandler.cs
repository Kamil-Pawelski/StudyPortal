using Application.Abstractions.Messaging;
using Domain.Entities.CardsSet;

namespace Application.Modules.CardsSet.GetRecent;

public class GetRecentCardsSetQueryHandler(ICardsSetRepository repository) : IQueryHandler<GetRecentCardsSetQuery, List<CardsSetDTO>>
{
    public async Task<List<CardsSetDTO>> Handle(GetRecentCardsSetQuery query, CancellationToken cancellationToken)
    {

    }
}

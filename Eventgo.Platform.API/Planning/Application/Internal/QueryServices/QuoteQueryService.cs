using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.Queries;
using Eventgo.Platform.API.Planning.Domain.Repositories;
using Eventgo.Platform.API.Planning.Domain.Services;

namespace Eventgo.Platform.API.Planning.Application.Internal.QueryServices;

public class QuoteQueryService(IQuoteRepository quoteRepository):IQuoteQueryService
{
    public async Task<IEnumerable<Quote>> Handle(GetAllQuotesByOrganizerIdQuery query)
    {
        return await quoteRepository.FindByOrganizerIdAsync(query.OrganizerId);
    }

    public async Task<Quote?> Handle(GetQuoteByIdQuery query)
    {
        return await quoteRepository.FindByIdAsync(query.QuoteId);
    }
}
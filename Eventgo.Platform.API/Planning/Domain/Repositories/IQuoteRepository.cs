using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Planning.Domain.Repositories;

public interface IQuoteRepository:IBaseRepository<Quote>
{
    Task<IEnumerable<Quote>> FindByOrganizerIdAsync(OrganizerId organizerId);
    Task<Quote?> FindByIdAsync(QuoteId quoteId);
}
using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Planning.Domain.Repositories;

public interface IServiceItemRepository:IBaseRepository<ServiceItem>
{
    Task<IEnumerable<ServiceItem>> FindByQuoteIdAsync(QuoteId quoteId);
    
    Task<ServiceItem?> FindByIdAsync(ServiceItemId serviceItemId);
}
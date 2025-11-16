using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.Queries;
using Eventgo.Platform.API.Planning.Domain.Repositories;
using Eventgo.Platform.API.Planning.Domain.Services;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Planning.Application.Internal.QueryServices;

public class ServiceItemQueryService(IServiceItemRepository serviceItemRepository, IUnitOfWork unitOfWork):IServiceItemQueryService
{
    public async Task<ServiceItem?> Handle(GetServiceItemByIdQuery query)
    {
        return await serviceItemRepository.FindByIdAsync(query.ServiceItemId);
    }

    public async Task<IEnumerable<ServiceItem>> Handle(GetAllServiceItemsByQuoteIdQuery query)
    {
        return await serviceItemRepository.FindByQuoteIdAsync(query.QuoteId);
    }
}
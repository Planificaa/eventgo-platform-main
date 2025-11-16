using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.Queries;

namespace Eventgo.Platform.API.Planning.Domain.Services;

public interface IServiceItemQueryService
{
    public Task<ServiceItem?> Handle(GetServiceItemByIdQuery query);
    
    public Task<IEnumerable<ServiceItem>> Handle(GetAllServiceItemsByQuoteIdQuery query);
}
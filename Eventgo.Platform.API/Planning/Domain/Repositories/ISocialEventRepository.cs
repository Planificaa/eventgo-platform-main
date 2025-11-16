using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Planning.Domain.Repositories;

public interface ISocialEventRepository : IBaseRepository<SocialEvent>
{
    Task<SocialEvent?> FindByEventTitleAsync(string eventTitle);

    Task<IEnumerable<SocialEvent>> FindByCustomerNameAsync(string customerName);

    Task<IEnumerable<SocialEvent>> FindByLocationAsync(string location);

    Task<IEnumerable<SocialEvent>> FindByDateRangeAsync(DateTime startDate, DateTime endDate);

    Task<IEnumerable<SocialEvent>> FindByStatusAsync(EStatusType status);
    
}
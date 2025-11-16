using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Profiles.Domain.Repositories;

public interface IServiceCatalogRepository : IBaseRepository<ServiceCatalog>
{
    Task<IEnumerable<ServiceCatalog>> ListByProfileIdAsync(int profileId);
    Task<ServiceCatalog?> FindByIdAndProfileIdAsync(int serviceCatalogId, int profileId);
}
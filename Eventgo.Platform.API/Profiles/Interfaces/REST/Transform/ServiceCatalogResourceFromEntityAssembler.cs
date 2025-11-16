using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Profiles.Interfaces.REST.Transform;

public class ServiceCatalogResourceFromEntityAssembler
{
    public static ServiceCatalogResource ToResourceFromEntity(ServiceCatalog entity)
    {
        return new ServiceCatalogResource(entity.Id, entity.ProfileId, entity.Title, entity.Description, entity.Category, entity.PriceFrom, entity.PriceTo);
    }
}
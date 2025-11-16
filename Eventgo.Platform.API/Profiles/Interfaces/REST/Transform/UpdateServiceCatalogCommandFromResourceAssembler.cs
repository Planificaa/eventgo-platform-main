using Eventgo.Platform.API.Profiles.Domain.Model.Commands;
using Eventgo.Platform.API.Profiles.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Profiles.Interfaces.REST.Transform;

public class UpdateServiceCatalogCommandFromResourceAssembler
{
    public static UpdateServiceCatalogCommand ToCommandFromResource(int profileId, int serviceCatalogId, UpdateServiceCatalogResource resource)
    {
        return new UpdateServiceCatalogCommand(profileId, serviceCatalogId, resource.Title, resource.Description, resource.Category, resource.PriceFrom, resource.PriceTo);
    }
}
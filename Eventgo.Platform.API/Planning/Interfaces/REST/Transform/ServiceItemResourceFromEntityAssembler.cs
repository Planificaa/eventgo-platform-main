using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;

public class ServiceItemResourceFromEntityAssembler
{
    public static ServiceItemResource ToResourceFromEntity(ServiceItem entity)
    {
        return new ServiceItemResource(entity.Id.Identifier.ToString(), entity.Description, entity.Quantity, entity.UnitPrice, entity.TotalPrice, entity.QuoteId.Identifier.ToString());
    }
}
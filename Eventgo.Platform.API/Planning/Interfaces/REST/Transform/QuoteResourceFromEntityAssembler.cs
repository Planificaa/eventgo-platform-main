using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;
using Microsoft.OpenApi.Extensions;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;

public class QuoteResourceFromEntityAssembler
{
    public static QuoteResource ToResourceFromEntity(Quote entity)
    {
        return new QuoteResource(
            entity.Id.Identifier.ToString(),
            entity.Title,
            entity.EventType.GetDisplayName(),
            entity.GuestQuantity,
            entity.Location,
            entity.TotalPrice,
            entity.Status.GetDisplayName(),
            entity.EventDate,
            entity.OrganizerId.Identifier,
            entity.HostId.Identifier
        );
    }
}
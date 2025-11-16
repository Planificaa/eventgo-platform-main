using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;

public class SocialEventResourceFromEntityAssembler
{
    public static SocialEventResource ToResourceFromEntity(SocialEvent entity)
    {
        return new SocialEventResource(
            entity.Id.IdSocialEvent.ToString(),
           entity.EventTitle,
            entity.EventDate,
            entity.NameCustomer.NameCustomer,
            entity.Location,
            entity.Status
        );
    }
}
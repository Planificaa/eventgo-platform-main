using Eventgo.Platform.API.Planning.Domain.Model.Commands;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;


public static class CreateSocialEventCommandFromResourceAssembler
{
    public static CreateSocialEventCommand ToCommandFromResource(CreateSocialEventResource resource)
    {
        return new CreateSocialEventCommand(
            resource.EventTitle,
            resource.EventDate,
            resource.CustomerName,
            resource.Location,
            resource.Status
        );
    }
}

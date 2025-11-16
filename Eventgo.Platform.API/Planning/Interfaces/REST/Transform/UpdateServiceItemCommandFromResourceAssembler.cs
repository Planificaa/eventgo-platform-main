using Eventgo.Platform.API.Planning.Domain.Model.Commands;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;

public class UpdateServiceItemCommandFromResourceAssembler
{
    public static UpdateServiceItemCommand ToCommandFromResource(string serviceItemId,UpdateServiceItemResource resource)
    {
        return new UpdateServiceItemCommand( new ServiceItemId(Guid.Parse(serviceItemId)),resource.Description, resource.Quantity, resource.UnitPrice, resource.TotalPrice);
    }
}
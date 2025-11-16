using Eventgo.Platform.API.Planning.Domain.Model.Commands;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Transform;

public class UpdateQuoteCommandFromResourceAssembler
{
    public static UpdateQuoteCommand ToCommandFromResource(string quoteId, UpdateQuoteResource resource)
    {
        return new UpdateQuoteCommand(new QuoteId(Guid.Parse(quoteId)), resource.Title,
            Enum.Parse<ESocialEventType>(resource.EventType), resource.GuestQuantity, resource.Location,
            resource.TotalPrice, resource.EventDate);
    }
}
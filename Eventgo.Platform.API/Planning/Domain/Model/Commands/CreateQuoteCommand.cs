using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Domain.Model.Commands;

public record CreateQuoteCommand(string Title, ESocialEventType EventType, int GuestQuantity, string Location, double TotalPrice, EQuoteStatus Status, DateTime EventDate, OrganizerId OrganizerId, HostId HostId);
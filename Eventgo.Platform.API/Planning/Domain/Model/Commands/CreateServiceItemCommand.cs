using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Domain.Model.Commands;

public record CreateServiceItemCommand(string Description, int Quantity, double UnitPrice, double TotalPrice, QuoteId QuoteId);
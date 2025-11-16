using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Domain.Model.Commands;

public record DeleteQuoteCommand(QuoteId QuoteId);
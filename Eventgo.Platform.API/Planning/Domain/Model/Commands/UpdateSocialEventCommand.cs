using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Domain.Model.Commands;

public record UpdateSocialEventCommand(
    int Id,
    string EventTitle,
    DateTime EventDate,
    string CustomerName,
    string Location,
    EStatusType Status
    );
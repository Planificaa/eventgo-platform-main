using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Interfaces.REST.Resources;

public record CreateSocialEventResource(
     string EventTitle,
     DateTime EventDate,
     string CustomerName,
     string Location,
     EStatusType Status
    );
    
    

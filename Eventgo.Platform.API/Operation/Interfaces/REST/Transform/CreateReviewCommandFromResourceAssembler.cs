using Eventgo.Platform.API.Operation.Domain.Model.Commands;
using Eventgo.Platform.API.Operation.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Operation.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Operation.Interfaces.REST.Transform;

public static class CreateReviewCommandFromResourceAssembler
{
    public static CreateReviewCommand ToCommandFromResource(CreateReviewResource resource)
    {
        return new CreateReviewCommand(
            resource.Reviewer,
            resource.EventName,
            resource.EventDate,
            resource.Content,
            resource.Rating,
            resource.ReviewDate
        );
    }
}
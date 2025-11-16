using Eventgo.Platform.API.Operation.Domain.Model.Aggregates;
using Eventgo.Platform.API.Operation.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Operation.Interfaces.REST.Transform;

public static class ReviewResourceFromEntityAssembler
{
    public static ReviewResource ToResourceFromEntity(Review entity)
    {
        return new ReviewResource(
            entity.Id,
            entity.Reviewer,
            entity.EventName,
            entity.EventDate,
            entity.Content,
            entity.Rating,
            entity.ReviewDate);
    }
}
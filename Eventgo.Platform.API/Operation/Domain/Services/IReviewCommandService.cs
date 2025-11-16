using Eventgo.Platform.API.Operation.Domain.Model.Aggregates;
using Eventgo.Platform.API.Operation.Domain.Model.Commands;

namespace Eventgo.Platform.API.Operation.Domain.Services;

public interface IReviewCommandService
{
    Task<Review?> Handle(CreateReviewCommand command);
}
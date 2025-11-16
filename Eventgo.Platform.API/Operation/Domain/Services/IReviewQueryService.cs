using Eventgo.Platform.API.Operation.Domain.Model.Aggregates;
using Eventgo.Platform.API.Operation.Domain.Model.Queries;

namespace Eventgo.Platform.API.Operation.Domain.Services;

public interface IReviewQueryService
{
    Task<Review?> Handle(GetReviewByIdQuery query);
    Task<IEnumerable<Review>> Handle(GetAllReviewsQuery query);
}
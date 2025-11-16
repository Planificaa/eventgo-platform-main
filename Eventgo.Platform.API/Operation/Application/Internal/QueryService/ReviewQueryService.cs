using Eventgo.Platform.API.Operation.Domain.Model.Aggregates;
using Eventgo.Platform.API.Operation.Domain.Model.Queries;
using Eventgo.Platform.API.Operation.Domain.Repositories;
using Eventgo.Platform.API.Operation.Domain.Services;

namespace Eventgo.Platform.API.Operation.Application.Internal.QueryService;

public class ReviewQueryService (IReviewRepository reviewRepository): IReviewQueryService
{
    public async Task<Review?> Handle(GetReviewByIdQuery query)
    {
        return await reviewRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Review>> Handle(GetAllReviewsQuery query)
    {
        return await reviewRepository.ListAsync();
    }
}
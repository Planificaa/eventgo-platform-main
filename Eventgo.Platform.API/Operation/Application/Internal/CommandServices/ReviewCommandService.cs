using Eventgo.Platform.API.Operation.Domain.Model.Aggregates;
using Eventgo.Platform.API.Operation.Domain.Model.Commands;
using Eventgo.Platform.API.Operation.Domain.Repositories;
using Eventgo.Platform.API.Operation.Domain.Services;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Operation.Application.Internal.CommandServices;

public class ReviewCommandService(
    IReviewRepository reviewRepository,
    IUnitOfWork unitOfWork
    ) :IReviewCommandService
{
    public async Task<Review?> Handle(CreateReviewCommand command)
    {
        var review = new Review(command);
        await reviewRepository.AddAsync(review);
        await unitOfWork.CompleteAsync();
        return review;
    }
}
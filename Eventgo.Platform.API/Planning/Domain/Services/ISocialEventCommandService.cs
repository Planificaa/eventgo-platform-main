using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.Commands;

namespace Eventgo.Platform.API.Planning.Domain.Services;

public interface ISocialEventCommandService
{
    Task<SocialEvent?> Handle(CreateSocialEventCommand command);
    Task<SocialEvent?> Handle(UpdateSocialEventCommand command);
    Task<SocialEvent?> Handle(DeleteSocialEventCommand command);
}
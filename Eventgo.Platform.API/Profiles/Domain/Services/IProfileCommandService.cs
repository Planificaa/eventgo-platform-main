using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Commands;

namespace Eventgo.Platform.API.Profiles.Domain.Services;

public interface IProfileCommandService
{

    Task<Profile?> Handle(CreateProfileCommand command);
}
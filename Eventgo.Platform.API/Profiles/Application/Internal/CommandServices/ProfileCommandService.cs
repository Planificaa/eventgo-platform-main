using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Commands;
using Eventgo.Platform.API.Profiles.Domain.Repositories;
using Eventgo.Platform.API.Profiles.Domain.Services;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Profiles.Application.Internal.CommandServices;

public class ProfileCommandService(
    IProfileRepository profileRepository,
    IUnitOfWork unitOfWork) : IProfileCommandService
{
    public async Task<Profile?> Handle(CreateProfileCommand command)
    {
        var profile = new Profile(command);
        try
        {
            await profileRepository.AddAsync(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        }catch (Exception ex)
        {
            // Log the exception (not implemented here)
            // Optionally, rethrow or handle the exception as needed
            return null;
        }
    }
}

using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Queries;
using Eventgo.Platform.API.Profiles.Domain.Repositories;
using Eventgo.Platform.API.Profiles.Domain.Services;

namespace Eventgo.Platform.API.Profiles.Application.Internal.QueryServices;

public class ProfileQueryService(
    IProfileRepository profileRepository
): IProfileQueryService
{
    public async Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query)
    {
        return await profileRepository.ListAsync();
    }

    public async Task<Profile?> Handle(GetProfileByIdQuery query)
    {
        return await profileRepository.FindByIdAsync(query.ProfileId);
    }

    public async Task<Profile?> Handle(GetProfileByEmailQuery query)
    {
        return await profileRepository.FindByEmailAsync(query.Email);
    }
}
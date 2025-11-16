using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Queries;

namespace Eventgo.Platform.API.Profiles.Domain.Services;

public interface IProfileQueryService
{
    Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query);
    Task<Profile?> Handle(GetProfileByIdQuery query);
    Task<Profile?> Handle(GetProfileByEmailQuery query);
}
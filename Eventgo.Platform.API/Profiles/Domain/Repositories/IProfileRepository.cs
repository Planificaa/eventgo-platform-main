using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Profiles.Domain.Repositories;

public interface IProfileRepository :IBaseRepository<Profile>
{
    Task<Profile?> FindByEmailAsync(EmailAddress email);
}
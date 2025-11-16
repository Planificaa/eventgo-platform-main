using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Profiles.Domain.Repositories;
using Eventgo.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using Eventgo.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Eventgo.Platform.API.Profiles.Infrastructure.Persistence.EFC.Repositories;

public class ProfileRepository(AppDbContext context) : BaseRepository<Profile>(context), IProfileRepository
{
    public async Task<Profile?> FindByEmailAsync(EmailAddress email)
    {
        return await Context.Set<Profile>().FirstOrDefaultAsync(p => p.Email.Address == email.Address);
    }
}
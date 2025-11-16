using Eventgo.Platform.API.Shared.Domain.Repositories;
using Eventgo.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace Eventgo.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}
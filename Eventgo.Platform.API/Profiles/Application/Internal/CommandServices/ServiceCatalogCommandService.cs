using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Commands;
using Eventgo.Platform.API.Profiles.Domain.Model.ValueObjects;
using Eventgo.Platform.API.Profiles.Domain.Repositories;
using Eventgo.Platform.API.Profiles.Domain.Services;
using Eventgo.Platform.API.Profiles.Interfaces.ACL;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Profiles.Application.Internal.CommandServices;

public class ServiceCatalogCommandService(
    IServiceCatalogRepository serviceCatalogRepository,
    IUnitOfWork unitOfWork,
    IProfilesContextFacade profilesContextFacade) : IServiceCatalogCommandService
{
    public async Task<ServiceCatalog?> Handle(CreateServiceCatalogCommand command)
    {
        var profileIsOrganizer = await profilesContextFacade.ProfileExistsWithRole(command.ProfileId, TypeProfile.Organizer);
        if (!profileIsOrganizer) return null;
        var serviceCatalog = new ServiceCatalog(command);
        try
        {
            await serviceCatalogRepository.AddAsync(serviceCatalog);
            await unitOfWork.CompleteAsync();
            return serviceCatalog;
        }
        catch
        {
            return null;
        }
    }

    public async Task<ServiceCatalog?> Handle(UpdateServiceCatalogCommand command)
    {
        var serviceCatalog = await serviceCatalogRepository.FindByIdAsync(command.ServiceCatalogId);
        if (serviceCatalog is null) return null;
        var profileIsOrganizer = await profilesContextFacade.ProfileExistsWithRole(serviceCatalog.ProfileId, TypeProfile.Organizer);
        if (!profileIsOrganizer) return null;
        serviceCatalog.Update(command.Title, command.Description, command.Category, command.PriceFrom, command.PriceTo);
        try
        {
            serviceCatalogRepository.Update(serviceCatalog);
            await unitOfWork.CompleteAsync();
            return serviceCatalog;
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> Handle(DeleteServiceCatalogCommand command)
    {
        var serviceCatalog = await serviceCatalogRepository.FindByIdAsync(command.ServiceCatalogId);
        if (serviceCatalog is null) return false;
        var profileIsOrganizer = await profilesContextFacade.ProfileExistsWithRole(serviceCatalog.ProfileId, TypeProfile.Organizer);
        if (!profileIsOrganizer) return false;
        try
        {
            serviceCatalogRepository.Remove(serviceCatalog);
            await unitOfWork.CompleteAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
using Eventgo.Platform.API.Profiles.Domain.Model.Commands;
using Eventgo.Platform.API.Profiles.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Profiles.Interfaces.REST.Transform;

public class CreateAlbumCommandFromResourceAssembler
{
    public static CreateAlbumCommand ToCommandFromResource(int profileId, CreateAlbumResource resource)
    {
        return new CreateAlbumCommand(profileId, resource.Name, resource.Photos);
    }
}
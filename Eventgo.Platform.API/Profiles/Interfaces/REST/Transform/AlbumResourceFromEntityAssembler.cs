using Eventgo.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Profiles.Interfaces.REST.Transform;

public class AlbumResourceFromEntityAssembler
{
    public static AlbumResource ToResourceFromEntity(Album entity)
    {
        var photos = entity.Photos.Select(p => p.Url);
        return new AlbumResource(entity.Id, entity.ProfileId, entity.Name, photos);
    }
}
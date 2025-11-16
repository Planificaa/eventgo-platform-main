using Eventgo.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventgo.Platform.API.Shared.Domain.Repositories;

namespace Eventgo.Platform.API.Profiles.Domain.Repositories;

public interface IAlbumRepository : IBaseRepository<Album>
{
    Task<IEnumerable<Album>> ListByProfileIdAsync(int profileId);
    Task<Album?> FindByIdAndProfileIdAsync(int albumId, int profileId);
}
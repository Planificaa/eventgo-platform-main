using Eventgo.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Queries;

namespace Eventgo.Platform.API.Profiles.Domain.Services;

public interface IAlbumQueryService
{
    Task<IEnumerable<Album>> Handle(GetAllAlbumsQuery query);
    Task<Album?> Handle(GetAlbumByIdQuery query);
    Task<IEnumerable<Album>> Handle(GetAlbumsByProfileIdQuery query);
    Task<Album?> Handle(GetAlbumByIdForProfileQuery query);
}
using Eventgo.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Domain.Model.Commands;

namespace Eventgo.Platform.API.Profiles.Domain.Services;

public interface IAlbumCommandService
{
    Task<Album?> Handle(CreateAlbumCommand command);
    Task<Album?> Handle(UpdateAlbumCommand command);
    Task<bool> Handle(DeleteAlbumCommand command);
}
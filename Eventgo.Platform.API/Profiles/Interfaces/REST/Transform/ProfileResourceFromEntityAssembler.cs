using Eventgo.Platform.API.Profiles.Domain.Model.Aggregates;
using Eventgo.Platform.API.Profiles.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.Profiles.Interfaces.REST.Transform;

public class ProfileResourceFromEntityAssembler
{
    public static ProfileResource ToResourceFromEntity(Profile entity)
    {
        return new ProfileResource(
            entity.Id,
            entity.FullName,
            entity.EmailAddress,
            entity.StreetAddress,
            entity.PhoneNumberValue,
            entity.WebSiteUrl,
            entity.BiographyText,
            entity.Role.ToString());
    }
}
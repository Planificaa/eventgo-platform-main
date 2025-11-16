using Eventgo.Platform.API.IAM.Domain.Model.Aggregates;
using Eventgo.Platform.API.IAM.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.IAM.Interfaces.REST.Transform;

public static class AuthenticatedUserResourceFromEntityAssembler
{
    public static AuthenticatedUserResource ToResourceFromEntity(
        User user, string token)
    {
        return new AuthenticatedUserResource(user.Id, user.Username, token);
    }
}
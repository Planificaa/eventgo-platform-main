using Eventgo.Platform.API.IAM.Domain.Model.Commands;
using Eventgo.Platform.API.IAM.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.IAM.Interfaces.REST.Transform;

public static class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}
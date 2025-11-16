using Eventgo.Platform.API.IAM.Domain.Model.Commands;
using Eventgo.Platform.API.IAM.Interfaces.REST.Resources;

namespace Eventgo.Platform.API.IAM.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}
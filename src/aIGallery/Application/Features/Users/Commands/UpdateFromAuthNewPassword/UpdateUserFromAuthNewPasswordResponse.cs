using Core.Application.Responses;
using Core.Security.JWT;

namespace Application.Features.Users.Commands.UpdateFromAuth;

public class UpdateUserFromAuthNewPasswordResponse : IResponse
{
    public bool Successful { get; set; }

    public UpdateUserFromAuthNewPasswordResponse()
    {

        Successful = false;
    }

    public UpdateUserFromAuthNewPasswordResponse(bool successful)
    {

        Successful = successful;
    }
}

using Application.Features.Users.Queries.GetById;
using Core.Application.Responses;
using Core.Security.JWT;

namespace Application.Features.Auth.Commands.Register;

public class RegisteredWithGoogleResponse : IResponse
{
    public AccessToken AccessToken { get; set; }
    public Core.Security.Entities.RefreshToken RefreshToken { get; set; }
     public RegisteredWithGoogleResponse()
    {
        AccessToken = null!;
        RefreshToken = null!;
     }

    public RegisteredWithGoogleResponse(AccessToken accessToken, Core.Security.Entities.RefreshToken refreshToken)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
     }
}

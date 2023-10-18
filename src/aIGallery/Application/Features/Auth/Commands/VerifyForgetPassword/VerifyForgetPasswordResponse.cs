using Application.Features.Users.Queries.GetById;
using Core.Application.Responses;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.VerifyForgetPassword;
public class VerifyForgetPasswordResponse : IResponse
{
    public AccessToken AccessToken { get; set; }
    public VerifyForgetPasswordResponse()
    {
        AccessToken = null!;
    }

    public VerifyForgetPasswordResponse(AccessToken accessToken, Core.Security.Entities.RefreshToken refreshToken)
    {
        AccessToken = accessToken;
    }
}

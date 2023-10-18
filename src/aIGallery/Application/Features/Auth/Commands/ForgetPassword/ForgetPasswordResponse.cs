using Core.Application.Responses;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.ForgetPassword;
public class ForgetPasswordResponse: IResponse
{
    public bool ForgetPassword { get; set; }
 
    public ForgetPasswordResponse()
    {
        ForgetPassword = false;
    }

    public ForgetPasswordResponse(bool forgetPassword)
    {
        ForgetPassword = forgetPassword;
    }
}

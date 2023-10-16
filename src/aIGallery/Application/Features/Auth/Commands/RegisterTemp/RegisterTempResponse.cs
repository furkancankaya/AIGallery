using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.RegisterTempUser;
public class RegisterTempResponse: IResponse
{
    public bool RegisterTemp { get; set; }
    public RegisterTempResponse()
    {
        RegisterTemp=false;
    }

    public RegisterTempResponse(bool registerTemp)
    {
        RegisterTemp = registerTemp;
    }
}

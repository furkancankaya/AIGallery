using Application.Features.Auth.Rules;
using Application.Services.AuthenticatorService;
using Application.Services.Repositories;
using Application.Services.UsersService;
using Core.Security.Entities;
using Core.Security.Enums;
using MediatR;

namespace Application.Features.Auth.Commands.VerifyOtpAuthenticator;

public class VerifyForgetPasswordCommand : IRequest<bool>
{
 
    public int Otp { get; set; }
    public string Email { get; set; }

    public VerifyForgetPasswordCommand()
    {
        Otp = 0;
    }

    public VerifyForgetPasswordCommand(int otp)
    {
        Otp = otp;
    }

    public class VerifyForgetPasswordCommandHandler : IRequestHandler<VerifyForgetPasswordCommand, bool>
    {
        private readonly AuthBusinessRules _authBusinessRules;
  
        private readonly IUserTempService _userTempService;


        public VerifyForgetPasswordCommandHandler(
            AuthBusinessRules authBusinessRules,
            IUserTempService userService
        )
        {
             _authBusinessRules = authBusinessRules;
            _userTempService = userService;
         }

        public async Task<bool> Handle(VerifyForgetPasswordCommand request, CancellationToken cancellationToken)
        {
          await _authBusinessRules.ForgetPasswordCheck(request.Otp,request.Email);
          return true;
        }
    }
}

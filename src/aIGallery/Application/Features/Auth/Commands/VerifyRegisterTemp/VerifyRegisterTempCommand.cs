using Application.Features.Auth.Rules;
using Application.Services.AuthenticatorService;
using Application.Services.Repositories;
using Application.Services.UsersService;
using Core.Security.Entities;
using Core.Security.Enums;
using MediatR;

namespace Application.Features.Auth.Commands.VerifyOtpAuthenticator;

public class VerifyRegisterTempCommand : IRequest<bool>
{

    public int Otp { get; set; }
    public string Email { get; set; }

    public VerifyRegisterTempCommand()
    {
        Otp = 0;
        Email = string.Empty;
    }

    public VerifyRegisterTempCommand(int otp,string email)
    {
        Otp = otp;
        Email = email;
    }

    public class VerifyRegisterTempCommandHandler : IRequestHandler<VerifyRegisterTempCommand, bool>
    {
        private readonly AuthBusinessRules _authBusinessRules;

        private readonly IUserTempService _userTempService;


        public VerifyRegisterTempCommandHandler(
            AuthBusinessRules authBusinessRules,
            IUserTempService userService
        )
        {
            _authBusinessRules = authBusinessRules;
            _userTempService = userService;
        }

        public async Task<bool> Handle(VerifyRegisterTempCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserTempCheck(request.Otp, request.Email);
            return true;
        }
    }
}

using Application.Features.Auth.Commands.RegisterTempUser;
using Application.Features.Auth.Rules;
using Application.Services.AuthenticatorService;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Core.Application.Dtos;
using Core.Security.Entities;
using Core.Security.Hashing;
using Core.Security.JWT;
using MediatR;

namespace Application.Features.Auth.Commands.Register;

public class RegisterTempCommand : IRequest<RegisterTempResponse>
{
    public string Email { get; set; }
    public string IpAddress { get; set; }

    public RegisterTempCommand()
    {
        Email = string.Empty;
        IpAddress = string.Empty;
    }

    public RegisterTempCommand(string email, string ipAddress)
    {
        Email = email;
        IpAddress = ipAddress;
    }

    public class RegisterTempCommandHandler : IRequestHandler<RegisterTempCommand, RegisterTempResponse>
    {
        private readonly IUserTempRepository _userTempRepository;
        private readonly IForgetPasswordRepository _forgetPasswordRepository;
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IAuthenticatorService _authenticatorService;

        public RegisterTempCommandHandler(IUserTempRepository userTempRepository,   AuthBusinessRules authBusinessRules, IAuthenticatorService authenticatorService)
        {
            _userTempRepository = userTempRepository;
         
            _authBusinessRules = authBusinessRules;
            _authenticatorService = authenticatorService;
        }

        public async Task<RegisterTempResponse> Handle(RegisterTempCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeNotExists(request.Email);


            int otp = await _authenticatorService.SendAuthenticatorCodeIntWithEmail(new User {Email = request.Email });
            UserTemp newUser =
                new()
                {
                    Email = request.Email,
                    OTP = otp
                };
            UserTemp createdUser = await _userTempRepository.AddAsync(newUser);
            RegisterTempResponse registerTempResponse = new RegisterTempResponse();
                registerTempResponse.RegisterTemp = true;
            return registerTempResponse;
        }
    }
}

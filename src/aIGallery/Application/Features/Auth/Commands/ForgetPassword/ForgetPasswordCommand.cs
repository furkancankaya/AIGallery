using Application.Features.Auth.Commands.ForgetPassword;
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

public class ForgetPasswordCommand : IRequest<ForgetPasswordResponse>
{
    public string Email { get; set; }
    public string IpAddress { get; set; }

    public ForgetPasswordCommand()
    {
        Email = null!;
        IpAddress = string.Empty;
    }

    public ForgetPasswordCommand(string email, string ipAddress)
    {
        Email = email;
        IpAddress = ipAddress;
    }

    public class ForgetPasswordCommandHandler : IRequestHandler<ForgetPasswordCommand, ForgetPasswordResponse>
    {
        private readonly IForgetPasswordRepository _forgetPasswordRepository;
         private readonly AuthBusinessRules _authBusinessRules;
        private readonly IAuthenticatorService _authenticatorService;

        public ForgetPasswordCommandHandler(IForgetPasswordRepository forgetPasswordRepository,   AuthBusinessRules authBusinessRules, IAuthenticatorService authenticatorService)
        {
            _forgetPasswordRepository = forgetPasswordRepository;
         
            _authBusinessRules = authBusinessRules;
            _authenticatorService = authenticatorService;
        }

        public async Task<ForgetPasswordResponse> Handle(ForgetPasswordCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeExists(request.Email);


            int otp = await _authenticatorService.SendAuthenticatorCodeIntWithEmail(new User { Email = request.Email });

           Core.Security.Entities.ForgetPassword forgetPassword =
                new()
                {
                    Email = request.Email,
                    OTP = otp
                };
            var createdUser = await _forgetPasswordRepository.AddAsync(forgetPassword);
            ForgetPasswordResponse forgetPasswordResponse = new ForgetPasswordResponse();
                forgetPasswordResponse.ForgetPassword = true;
            return forgetPasswordResponse;
        }
    }
}

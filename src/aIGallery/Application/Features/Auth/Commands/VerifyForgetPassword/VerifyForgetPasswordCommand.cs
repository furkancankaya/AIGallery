using Application.Features.Auth.Commands.VerifyForgetPassword;
using Application.Features.Auth.Rules;
using Application.Services.AuthenticatorService;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Application.Services.UsersService;
using Core.Security.Entities;
using Core.Security.Enums;
using Core.Security.JWT;
using MediatR;

namespace Application.Features.Auth.Commands.VerifyOtpAuthenticator;

public class VerifyForgetPasswordCommand : IRequest<VerifyForgetPasswordResponse>
{

    public int Otp { get; set; }
    public string Email { get; set; }
    public string IpAddress { get; set; }

    public VerifyForgetPasswordCommand()
    {
        Otp = 0;
        IpAddress=string.Empty;
        Email=string.Empty;
    }

    public VerifyForgetPasswordCommand(int otp,string email,string ipAddress)
    {
        Otp = otp;
        Email = email;
        IpAddress = ipAddress;
    }

    public class VerifyForgetPasswordCommandHandler : IRequestHandler<VerifyForgetPasswordCommand, VerifyForgetPasswordResponse>
    {
        private readonly AuthBusinessRules _authBusinessRules;

        private readonly IUserTempService _userTempService;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public VerifyForgetPasswordCommandHandler(
            AuthBusinessRules authBusinessRules,
            IUserTempService userTempService,
             IAuthService authService,
            IUserService userService
        )
        {
            _authBusinessRules = authBusinessRules;
            _userTempService = userTempService;
            _authService = authService;
            _userService = userService;
        }

        public async Task<VerifyForgetPasswordResponse> Handle(VerifyForgetPasswordCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.ForgetPasswordCheck(request.Otp, request.Email);

            User? user = await _userService.GetAsync(
            predicate: u => u.Email == request.Email,
            cancellationToken: cancellationToken);


            AccessToken createdAccessToken = await _authService.CreateAccessToken(user);
            Core.Security.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(user, request.IpAddress);
            Core.Security.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);
            await _authService.DeleteOldRefreshTokens(user.Id);

            VerifyForgetPasswordResponse verifyForgetPasswordResponse = new VerifyForgetPasswordResponse();
            verifyForgetPasswordResponse.AccessToken = createdAccessToken;
            return verifyForgetPasswordResponse;
        }
    }
}

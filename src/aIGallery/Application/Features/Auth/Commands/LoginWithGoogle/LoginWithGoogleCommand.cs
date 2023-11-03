using Application.Features.Auth.Rules;
using Application.Features.Users.Queries.GetById;
using Application.Services.AuthenticatorService;
using Application.Services.AuthService;
using Application.Services.UsersService;
using Core.Application.Dtos;
using Core.Security.Entities;
using Core.Security.Enums;
using Core.Security.JWT;
using MediatR;

namespace Application.Features.Auth.Commands.Login;

public class LoginWithGoogleCommand : IRequest<LoggedWithGoogleResponse>
{
    public UserForLoginWithGoogleDto UserForLoginWithGoogleDto { get; set; }
    public string IpAddress { get; set; }

    public LoginWithGoogleCommand()
    {
        UserForLoginWithGoogleDto = null!;
        IpAddress = string.Empty;
    }

    public LoginWithGoogleCommand(UserForLoginWithGoogleDto userForLoginWithGoogleDto, string ipAddress)
    {
        UserForLoginWithGoogleDto = userForLoginWithGoogleDto;
        IpAddress = ipAddress;
    }

    public class LoginCommandHandler : IRequestHandler<LoginWithGoogleCommand, LoggedWithGoogleResponse>
    {
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IAuthenticatorService _authenticatorService;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public LoginCommandHandler(
            IUserService userService,
            IAuthService authService,
            AuthBusinessRules authBusinessRules,
            IAuthenticatorService authenticatorService
        )
        {
            _userService = userService;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
            _authenticatorService = authenticatorService;
        }

        public async Task<LoggedWithGoogleResponse> Handle(LoginWithGoogleCommand request, CancellationToken cancellationToken)
        {
            User? user = await _userService.GetAsync(
                predicate: u => u.Email == request.UserForLoginWithGoogleDto.Email,
                cancellationToken: cancellationToken
            );
            await _authBusinessRules.UserShouldBeExistsWhenSelected(user);
            

            LoggedWithGoogleResponse loggedResponse = new();

            if (user.AuthenticatorType is not AuthenticatorType.None)
            {
                if (request.UserForLoginWithGoogleDto.AuthenticatorCode is null)
                {
                    await _authenticatorService.SendAuthenticatorCode(user);
                    loggedResponse.RequiredAuthenticatorType = user.AuthenticatorType;
                    return loggedResponse;
                }

                await _authenticatorService.VerifyAuthenticatorCode(user, request.UserForLoginWithGoogleDto.AuthenticatorCode);
            }

            AccessToken createdAccessToken = await _authService.CreateAccessToken(user);

            Core.Security.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(user, request.IpAddress);
            Core.Security.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);
            await _authService.DeleteOldRefreshTokens(user.Id);

            loggedResponse.AccessToken = createdAccessToken;
            loggedResponse.RefreshToken = addedRefreshToken;
              return loggedResponse;
        }
    }
}

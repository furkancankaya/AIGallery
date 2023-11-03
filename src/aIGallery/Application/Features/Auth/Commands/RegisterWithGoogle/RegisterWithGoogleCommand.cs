using Application.Features.Auth.Commands.Login;
using Application.Features.Auth.Rules;
using Application.Features.Users.Queries.GetById;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Core.Application.Dtos;
using Core.Security.Entities;
using Core.Security.Hashing;
using Core.Security.JWT;
using MediatR;
using System.Security.Cryptography;

namespace Application.Features.Auth.Commands.Register;

public class RegisterWithGoogleCommand : IRequest<RegisteredWithGoogleResponse>
{
    public UserForRegisterWithGoogleDto UserForRegisterWithGoogleDto { get; set; }
    public string IpAddress { get; set; }

    public RegisterWithGoogleCommand()
    {
        UserForRegisterWithGoogleDto = null!;
        IpAddress = string.Empty;
    }

    public RegisterWithGoogleCommand(UserForRegisterWithGoogleDto userForRegisterWithGoogleDto, string ipAddress)
    {
        UserForRegisterWithGoogleDto = userForRegisterWithGoogleDto;
        IpAddress = ipAddress;
    }



    public class RegisterWithGoogleCommandHandler : IRequestHandler<RegisterWithGoogleCommand, RegisteredWithGoogleResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        private readonly AuthBusinessRules _authBusinessRules;

        public RegisterWithGoogleCommandHandler(IUserRepository userRepository, IAuthService authService, AuthBusinessRules authBusinessRules)
        {
            _userRepository = userRepository;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
        }


        public static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=<>?";

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                char[] password = new char[length];
                for (int i = 0; i < length; i++)
                {
                    password[i] = validChars[randomBytes[i] % validChars.Length];
                }
                return new string(password);
            }
        }

        public async Task<RegisteredWithGoogleResponse> Handle(RegisterWithGoogleCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterWithGoogleDto.Email);
            await _authBusinessRules.UserNickShouldBeNotExists(request.UserForRegisterWithGoogleDto.Nick);


            string uniquePassword = GeneratePassword(12);

            HashingHelper.CreatePasswordHash(
                uniquePassword,
                passwordHash: out byte[] passwordHash,
                passwordSalt: out byte[] passwordSalt
            );
            User newUser =
                new()
                {
                    Email = request.UserForRegisterWithGoogleDto.Email,
                    FirstName = request.UserForRegisterWithGoogleDto.Nick,
                    LastName = string.Empty,
                    Nick = request.UserForRegisterWithGoogleDto.Nick,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true,
                    Pro=false,
                    Token=10,
                    Blocked=false
                    
                };
            User createdUser = await _userRepository.AddAsync(newUser);

            AccessToken createdAccessToken = await _authService.CreateAccessToken(createdUser);

            Core.Security.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(createdUser, request.IpAddress);
            Core.Security.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);

            RegisteredWithGoogleResponse registeredWithGoogleResponse = new() { AccessToken = createdAccessToken, RefreshToken = addedRefreshToken };
 
            return registeredWithGoogleResponse;
        }
    }
}

﻿using Application.Features.Auth.Commands.Login;
using Application.Features.Auth.Constants;
using Application.Features.Auth.Rules;
using Application.Features.Users.Queries.GetById;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Core.Application.Dtos;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;
using Core.Security.Hashing;
using Core.Security.JWT;
using MediatR;

namespace Application.Features.Auth.Commands.Register;

public class RegisterCommand : IRequest<RegisteredResponse>
{
    public UserForRegisterDto UserForRegisterDto { get; set; }
    public string IpAddress { get; set; }

    public RegisterCommand()
    {
        UserForRegisterDto = null!;
        IpAddress = string.Empty;
    }

    public RegisterCommand(UserForRegisterDto userForRegisterDto, string ipAddress)
    {
        UserForRegisterDto = userForRegisterDto;
        IpAddress = ipAddress;
    }

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        private readonly AuthBusinessRules _authBusinessRules;

        public RegisterCommandHandler(IUserRepository userRepository, IAuthService authService, AuthBusinessRules authBusinessRules)
        {
            _userRepository = userRepository;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
        }

        public async Task<RegisteredResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterDto.Email);
            await _authBusinessRules.UserNickShouldBeNotExists(request.UserForRegisterDto.Nick);
            

            HashingHelper.CreatePasswordHash(
                request.UserForRegisterDto.Password,
                passwordHash: out byte[] passwordHash,
                passwordSalt: out byte[] passwordSalt
            );
            User newUser =
                new()
                {
                    Email = request.UserForRegisterDto.Email,
                    FirstName = request.UserForRegisterDto.Nick,
                    LastName = string.Empty,
                    Nick = request.UserForRegisterDto.Nick,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true,
                    Pro=false,
                    Token=10,
                    Blocked=false,
                    Photo = "Images/Default.png"

        };
            User createdUser = await _userRepository.AddAsync(newUser);
            AccessToken createdAccessToken = await _authService.CreateAccessToken(createdUser);

            Core.Security.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(createdUser, request.IpAddress);
            Core.Security.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);

            RegisteredResponse registeredResponse = new() { AccessToken = createdAccessToken, RefreshToken = addedRefreshToken };
 
            return registeredResponse;
        }
    }
}

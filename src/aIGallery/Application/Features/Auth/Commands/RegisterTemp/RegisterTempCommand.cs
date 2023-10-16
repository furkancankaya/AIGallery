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
    public UserForRegisterDto UserForRegisterDto { get; set; }
    public string IpAddress { get; set; }

    public RegisterTempCommand()
    {
        UserForRegisterDto = null!;
        IpAddress = string.Empty;
    }

    public RegisterTempCommand(UserForRegisterDto userForRegisterDto, string ipAddress)
    {
        UserForRegisterDto = userForRegisterDto;
        IpAddress = ipAddress;
    }

    public class RegisterTempCommandHandler : IRequestHandler<RegisterTempCommand, RegisterTempResponse>
    {
        private readonly IUserTempRepository _userTempRepository;
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
            await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterDto.Email);


            int otp = await _authenticatorService.SendAuthenticatorCodeIntWithEmail(new User { FirstName = request.UserForRegisterDto.FirstName, LastName = request.UserForRegisterDto.LastName, Email = request.UserForRegisterDto.Email });
            UserTemp newUser =
                new()
                {
                    Email = request.UserForRegisterDto.Email,
                    OTP = otp
                };
            UserTemp createdUser = await _userTempRepository.AddAsync(newUser);
            RegisterTempResponse registerTempResponse = new RegisterTempResponse();
                registerTempResponse.RegisterTemp = true;
            return registerTempResponse;
        }
    }
}

using Application.Features.Users.Rules;
using Application.Services.AuthService;
using Application.Services.Repositories;
using AutoMapper;
using Core.Security.Entities;
using Core.Security.Hashing;
using MediatR;

namespace Application.Features.Users.Commands.UpdateFromAuth;

public class UpdateUserFromAuthNewPasswordCommand : IRequest<UpdateUserFromAuthNewPasswordResponse>
{
    public int Id { get; set; }
    public string? NewPassword { get; set; }

    public UpdateUserFromAuthNewPasswordCommand()
    {
        Id = 0;
        NewPassword = string.Empty;

    }

    public UpdateUserFromAuthNewPasswordCommand(int id,string newPassword)
    {
        NewPassword = newPassword;
        Id = id;
    }

    public class UpdateUserFromAuthNewPasswordCommandHandler : IRequestHandler<UpdateUserFromAuthNewPasswordCommand, UpdateUserFromAuthNewPasswordResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IAuthService _authService;

        public UpdateUserFromAuthNewPasswordCommandHandler(
            IUserRepository userRepository,
            IMapper mapper,
            UserBusinessRules userBusinessRules,
            IAuthService authService
        )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
            _authService = authService;
        }

        public async Task<UpdateUserFromAuthNewPasswordResponse> Handle(UpdateUserFromAuthNewPasswordCommand request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(predicate: u => u.Id == request.Id, cancellationToken: cancellationToken);
            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);

            if (request.NewPassword != null && !string.IsNullOrWhiteSpace(request.NewPassword))
            {
                HashingHelper.CreatePasswordHash(
                    request.NewPassword,
                    passwordHash: out byte[] passwordHash,
                    passwordSalt: out byte[] passwordSalt
                );
                user!.PasswordHash = passwordHash;
                user!.PasswordSalt = passwordSalt;
            }
            User updatedUser = await _userRepository.UpdateAsync(user!);

            UpdateUserFromAuthNewPasswordResponse response = new UpdateUserFromAuthNewPasswordResponse();
            response.Successful = true;
            return response;
        }
    }
}

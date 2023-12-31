using Application.Features.BannedPrompts.Constants;
using Application.Features.Users.Constants;
using Application.Features.Users.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using Core.Security.Hashing;
using MediatR;
using OtpNet;
using System.Threading;
using static Application.Features.Users.Constants.UsersOperationClaims;

namespace Application.Features.Users.Commands.Update;

public class UpdateUserCommand : IRequest<UpdatedUserResponse>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Nick { get; set; }
    public string? Photo { get; set; }

    // public string[] Roles => Array.Empty<string>();, ISecuredRequest

    public UpdateUserCommand()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        Nick = string.Empty;
        Photo = string.Empty;
    }
    public UpdateUserCommand(int id, string firstName, string lastName, string email, string password, string nick, string photo)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Nick = nick;
        Photo = photo;
    }



    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdatedUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }

        public string SaveBase64Image(string base64Image, string imageFolderPath, string fileName)
        {

            byte[] imageBytes = Convert.FromBase64String(base64Image);

            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }


            string filePath = Path.Combine(imageFolderPath, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            File.WriteAllBytes(filePath, imageBytes);

            return filePath;
        }

        public async Task<UpdatedUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(predicate: u => u.Id == request.Id, cancellationToken: cancellationToken);
            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);
 
            string imageFolderPath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot", "Images");
            string fileName = $"{user.Id}_profile_image.png";
 
            if (!string.IsNullOrEmpty(request.Photo))
            {
                string imagePath = SaveBase64Image(request.Photo, imageFolderPath, fileName);
                string[] parts = imagePath.Split(new string[] { "\\" }, StringSplitOptions.None);
                string photo = "Images/" + parts.Last();
                user.Photo = photo;
             
            }
            

            if (!string.IsNullOrEmpty(request.Email))
            {
                await _userBusinessRules.UserEmailShouldNotExistsWhenUpdate(user!.Id, request.Email);
                user.Email = request.Email;
            }
            if (!string.IsNullOrEmpty(request.Nick))
            {
                await _userBusinessRules.UserNickShouldNotExistsWhenUpdate(user!.Id, request.Nick);
                user.Nick = request.Nick;
            }
            if (!string.IsNullOrEmpty(request.FirstName))
            {
                user.FirstName = request.FirstName;
            }
            if (!string.IsNullOrEmpty(request.LastName))
            {
                user.LastName = request.LastName;
            }
            if (!string.IsNullOrEmpty(request.Password))
            {
                HashingHelper.CreatePasswordHash(
                    request.Password,
                    passwordHash: out byte[] passwordHash,
                    passwordSalt: out byte[] passwordSalt
                );
                user!.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            await _userRepository.UpdateAsync(user);

            UpdatedUserResponse response = _mapper.Map<UpdatedUserResponse>(user);
            return response;
        }
    }
}

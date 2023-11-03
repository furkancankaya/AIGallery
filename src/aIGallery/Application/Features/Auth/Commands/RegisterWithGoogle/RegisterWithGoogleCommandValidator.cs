using FluentValidation;

namespace Application.Features.Auth.Commands.Register;

public class RegisterWithGoogleCommandValidator : AbstractValidator<RegisterWithGoogleCommand>
{
    public RegisterWithGoogleCommandValidator()
    {
        RuleFor(c => c.UserForRegisterWithGoogleDto.Nick).NotEmpty().MinimumLength(2);
        RuleFor(c => c.UserForRegisterWithGoogleDto.Email).NotEmpty().EmailAddress();
    }
}

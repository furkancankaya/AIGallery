using FluentValidation;

namespace Application.Features.Auth.Commands.Login;

public class LoginWithGoogleCommandValidator : AbstractValidator<LoginWithGoogleCommand>
{
    public LoginWithGoogleCommandValidator()
    {
        RuleFor(c => c.UserForLoginWithGoogleDto.Email).NotEmpty().EmailAddress();
    }
}

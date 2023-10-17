using Application.Features.Auth.Commands.Register;
using FluentValidation;

namespace Application.Features.Auth.Commands.Forget;

public class ForgetPasswordCommandValidator : AbstractValidator<ForgetPasswordCommand>
{
    public ForgetPasswordCommandValidator()
    {
        RuleFor(c => c.Email).NotEmpty().EmailAddress();
    }
}

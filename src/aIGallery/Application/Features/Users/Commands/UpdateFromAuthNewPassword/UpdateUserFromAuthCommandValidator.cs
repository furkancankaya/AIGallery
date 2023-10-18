using FluentValidation;

namespace Application.Features.Users.Commands.UpdateFromAuth;

public class UpdateUserFromAuthNewPasswordValidator : AbstractValidator<UpdateUserFromAuthNewPasswordCommand>
{
    public UpdateUserFromAuthNewPasswordValidator()
    {
 
        RuleFor(c => c.NewPassword).NotEmpty().MinimumLength(4);
    }
}

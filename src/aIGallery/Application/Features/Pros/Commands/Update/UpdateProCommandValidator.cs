using FluentValidation;

namespace Application.Features.Pros.Commands.Update;

public class UpdateProCommandValidator : AbstractValidator<UpdateProCommand>
{
    public UpdateProCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Type).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
    }
}
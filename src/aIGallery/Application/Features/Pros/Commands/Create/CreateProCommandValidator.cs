using FluentValidation;

namespace Application.Features.Pros.Commands.Create;

public class CreateProCommandValidator : AbstractValidator<CreateProCommand>
{
    public CreateProCommandValidator()
    {
        RuleFor(c => c.Type).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
    }
}
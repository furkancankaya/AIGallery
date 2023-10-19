using FluentValidation;

namespace Application.Features.Pros.Commands.Delete;

public class DeleteProCommandValidator : AbstractValidator<DeleteProCommand>
{
    public DeleteProCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
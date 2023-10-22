using FluentValidation;

namespace Application.Features.PreparedPrompts.Commands.Delete;

public class DeletePreparedPromptCommandValidator : AbstractValidator<DeletePreparedPromptCommand>
{
    public DeletePreparedPromptCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
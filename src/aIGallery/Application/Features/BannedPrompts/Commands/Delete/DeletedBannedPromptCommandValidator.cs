using FluentValidation;

namespace Application.Features.BannedPrompts.Commands.Delete;

public class DeleteBannedPromptCommandValidator : AbstractValidator<DeleteBannedPromptCommand>
{
    public DeleteBannedPromptCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
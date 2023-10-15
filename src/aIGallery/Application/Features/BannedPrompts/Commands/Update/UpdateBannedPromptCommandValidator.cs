using FluentValidation;

namespace Application.Features.BannedPrompts.Commands.Update;

public class UpdateBannedPromptCommandValidator : AbstractValidator<UpdateBannedPromptCommand>
{
    public UpdateBannedPromptCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Prompt).NotEmpty();
    }
}
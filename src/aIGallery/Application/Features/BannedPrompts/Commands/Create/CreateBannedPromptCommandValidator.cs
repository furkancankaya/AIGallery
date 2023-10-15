using FluentValidation;

namespace Application.Features.BannedPrompts.Commands.Create;

public class CreateBannedPromptCommandValidator : AbstractValidator<CreateBannedPromptCommand>
{
    public CreateBannedPromptCommandValidator()
    {
        RuleFor(c => c.Prompt).NotEmpty();
    }
}
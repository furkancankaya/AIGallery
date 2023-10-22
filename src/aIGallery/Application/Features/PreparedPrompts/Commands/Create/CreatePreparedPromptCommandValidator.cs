using FluentValidation;

namespace Application.Features.PreparedPrompts.Commands.Create;

public class CreatePreparedPromptCommandValidator : AbstractValidator<CreatePreparedPromptCommand>
{
    public CreatePreparedPromptCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Logo).NotEmpty();
        RuleFor(c => c.Prompt).NotEmpty();
        RuleFor(c => c.TextToImage).NotEmpty();
        RuleFor(c => c.Gender).NotEmpty();
        RuleFor(c => c.Sort).NotEmpty();
    }
}
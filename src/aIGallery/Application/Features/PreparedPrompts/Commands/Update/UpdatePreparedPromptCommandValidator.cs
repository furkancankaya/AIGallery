using FluentValidation;

namespace Application.Features.PreparedPrompts.Commands.Update;

public class UpdatePreparedPromptCommandValidator : AbstractValidator<UpdatePreparedPromptCommand>
{
    public UpdatePreparedPromptCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Logo).NotEmpty();
        RuleFor(c => c.Prompt).NotEmpty();
        RuleFor(c => c.TextToImage).NotEmpty();
        RuleFor(c => c.Gender).NotEmpty();
        RuleFor(c => c.Sort).NotEmpty();
    }
}
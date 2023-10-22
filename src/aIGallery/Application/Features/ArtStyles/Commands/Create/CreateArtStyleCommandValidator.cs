using FluentValidation;

namespace Application.Features.ArtStyles.Commands.Create;

public class CreateArtStyleCommandValidator : AbstractValidator<CreateArtStyleCommand>
{
    public CreateArtStyleCommandValidator()
    {
        RuleFor(c => c.Logo).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Prompt).NotEmpty();
        RuleFor(c => c.Sort).NotEmpty();
    }
}
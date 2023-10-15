using FluentValidation;

namespace Application.Features.ArtStyles.Commands.Create;

public class CreateArtStyleCommandValidator : AbstractValidator<CreateArtStyleCommand>
{
    public CreateArtStyleCommandValidator()
    {
        RuleFor(c => c.Image).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}
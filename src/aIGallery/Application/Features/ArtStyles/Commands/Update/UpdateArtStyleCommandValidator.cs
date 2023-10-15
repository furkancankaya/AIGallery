using FluentValidation;

namespace Application.Features.ArtStyles.Commands.Update;

public class UpdateArtStyleCommandValidator : AbstractValidator<UpdateArtStyleCommand>
{
    public UpdateArtStyleCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Image).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}
using FluentValidation;

namespace Application.Features.ArtStyles.Commands.Update;

public class UpdateArtStyleCommandValidator : AbstractValidator<UpdateArtStyleCommand>
{
    public UpdateArtStyleCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Logo).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Prompt).NotEmpty();
        RuleFor(c => c.Sort).NotEmpty();
    }
}
using FluentValidation;

namespace Application.Features.ArtStyles.Commands.Delete;

public class DeleteArtStyleCommandValidator : AbstractValidator<DeleteArtStyleCommand>
{
    public DeleteArtStyleCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
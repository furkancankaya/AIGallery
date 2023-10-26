using FluentValidation;

namespace Application.Features.Likes.Commands.Delete;

public class DeleteLikeCommandValidator : AbstractValidator<DeleteLikeCommand>
{
    public DeleteLikeCommandValidator()
    {
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.ImageId).NotEmpty();
    }
}
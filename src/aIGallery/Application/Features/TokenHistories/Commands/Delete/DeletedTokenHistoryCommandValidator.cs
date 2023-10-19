using FluentValidation;

namespace Application.Features.TokenHistories.Commands.Delete;

public class DeleteTokenHistoryCommandValidator : AbstractValidator<DeleteTokenHistoryCommand>
{
    public DeleteTokenHistoryCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
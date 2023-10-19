using FluentValidation;

namespace Application.Features.TokenHistories.Commands.Update;

public class UpdateTokenHistoryCommandValidator : AbstractValidator<UpdateTokenHistoryCommand>
{
    public UpdateTokenHistoryCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Amount).NotEmpty();
        RuleFor(c => c.Price).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
    }
}
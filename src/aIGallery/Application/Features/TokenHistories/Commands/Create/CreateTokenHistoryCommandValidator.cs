using FluentValidation;

namespace Application.Features.TokenHistories.Commands.Create;

public class CreateTokenHistoryCommandValidator : AbstractValidator<CreateTokenHistoryCommand>
{
    public CreateTokenHistoryCommandValidator()
    {
        RuleFor(c => c.Amount).NotEmpty();

    }
}
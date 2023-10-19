using Application.Features.TokenHistories.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.TokenHistories.Rules;

public class TokenHistoryBusinessRules : BaseBusinessRules
{
    private readonly ITokenHistoryRepository _tokenHistoryRepository;


    public TokenHistoryBusinessRules(ITokenHistoryRepository tokenHistoryRepository)
    {
        _tokenHistoryRepository = tokenHistoryRepository;
    }

    public Task TokenHistoryShouldExistWhenSelected(TokenHistory? tokenHistory)
    {
        if (tokenHistory == null)
            throw new BusinessException(TokenHistoriesBusinessMessages.TokenHistoryNotExists);
        return Task.CompletedTask;
    }

    public async Task TokenHistoryIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        TokenHistory? tokenHistory = await _tokenHistoryRepository.GetAsync(
            predicate: th => th.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await TokenHistoryShouldExistWhenSelected(tokenHistory);
    }
}
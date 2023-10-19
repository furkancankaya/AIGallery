using Application.Features.TokenHistories.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.TokenHistories;

public class TokenHistoriesManager : ITokenHistoriesService
{
    private readonly ITokenHistoryRepository _tokenHistoryRepository;
    private readonly TokenHistoryBusinessRules _tokenHistoryBusinessRules;

    public TokenHistoriesManager(ITokenHistoryRepository tokenHistoryRepository, TokenHistoryBusinessRules tokenHistoryBusinessRules)
    {
        _tokenHistoryRepository = tokenHistoryRepository;
        _tokenHistoryBusinessRules = tokenHistoryBusinessRules;
    }

    public async Task<TokenHistory?> GetAsync(
        Expression<Func<TokenHistory, bool>> predicate,
        Func<IQueryable<TokenHistory>, IIncludableQueryable<TokenHistory, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        TokenHistory? tokenHistory = await _tokenHistoryRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return tokenHistory;
    }

    public async Task<IPaginate<TokenHistory>?> GetListAsync(
        Expression<Func<TokenHistory, bool>>? predicate = null,
        Func<IQueryable<TokenHistory>, IOrderedQueryable<TokenHistory>>? orderBy = null,
        Func<IQueryable<TokenHistory>, IIncludableQueryable<TokenHistory, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<TokenHistory> tokenHistoryList = await _tokenHistoryRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return tokenHistoryList;
    }

    public async Task<TokenHistory> AddAsync(TokenHistory tokenHistory)
    {
        TokenHistory addedTokenHistory = await _tokenHistoryRepository.AddAsync(tokenHistory);

        return addedTokenHistory;
    }

    public async Task<TokenHistory> UpdateAsync(TokenHistory tokenHistory)
    {
        TokenHistory updatedTokenHistory = await _tokenHistoryRepository.UpdateAsync(tokenHistory);

        return updatedTokenHistory;
    }

    public async Task<TokenHistory> DeleteAsync(TokenHistory tokenHistory, bool permanent = false)
    {
        TokenHistory deletedTokenHistory = await _tokenHistoryRepository.DeleteAsync(tokenHistory);

        return deletedTokenHistory;
    }
}

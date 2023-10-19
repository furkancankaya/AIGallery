using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.TokenHistories;

public interface ITokenHistoriesService
{
    Task<TokenHistory?> GetAsync(
        Expression<Func<TokenHistory, bool>> predicate,
        Func<IQueryable<TokenHistory>, IIncludableQueryable<TokenHistory, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<TokenHistory>?> GetListAsync(
        Expression<Func<TokenHistory, bool>>? predicate = null,
        Func<IQueryable<TokenHistory>, IOrderedQueryable<TokenHistory>>? orderBy = null,
        Func<IQueryable<TokenHistory>, IIncludableQueryable<TokenHistory, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<TokenHistory> AddAsync(TokenHistory tokenHistory);
    Task<TokenHistory> UpdateAsync(TokenHistory tokenHistory);
    Task<TokenHistory> DeleteAsync(TokenHistory tokenHistory, bool permanent = false);
}

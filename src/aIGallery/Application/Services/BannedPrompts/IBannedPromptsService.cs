using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BannedPrompts;

public interface IBannedPromptsService
{
    Task<BannedPrompt?> GetAsync(
        Expression<Func<BannedPrompt, bool>> predicate,
        Func<IQueryable<BannedPrompt>, IIncludableQueryable<BannedPrompt, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<BannedPrompt>?> GetListAsync(
        Expression<Func<BannedPrompt, bool>>? predicate = null,
        Func<IQueryable<BannedPrompt>, IOrderedQueryable<BannedPrompt>>? orderBy = null,
        Func<IQueryable<BannedPrompt>, IIncludableQueryable<BannedPrompt, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<BannedPrompt> AddAsync(BannedPrompt bannedPrompt);
    Task<BannedPrompt> UpdateAsync(BannedPrompt bannedPrompt);
    Task<BannedPrompt> DeleteAsync(BannedPrompt bannedPrompt, bool permanent = false);
}

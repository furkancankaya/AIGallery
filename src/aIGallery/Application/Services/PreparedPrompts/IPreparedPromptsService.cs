using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.PreparedPrompts;

public interface IPreparedPromptsService
{
    Task<PreparedPrompt?> GetAsync(
        Expression<Func<PreparedPrompt, bool>> predicate,
        Func<IQueryable<PreparedPrompt>, IIncludableQueryable<PreparedPrompt, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<PreparedPrompt>?> GetListAsync(
        Expression<Func<PreparedPrompt, bool>>? predicate = null,
        Func<IQueryable<PreparedPrompt>, IOrderedQueryable<PreparedPrompt>>? orderBy = null,
        Func<IQueryable<PreparedPrompt>, IIncludableQueryable<PreparedPrompt, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<PreparedPrompt> AddAsync(PreparedPrompt preparedPrompt);
    Task<PreparedPrompt> UpdateAsync(PreparedPrompt preparedPrompt);
    Task<PreparedPrompt> DeleteAsync(PreparedPrompt preparedPrompt, bool permanent = false);
}

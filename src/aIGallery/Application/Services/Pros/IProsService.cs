using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Pros;

public interface IProsService
{
    Task<Pro?> GetAsync(
        Expression<Func<Pro, bool>> predicate,
        Func<IQueryable<Pro>, IIncludableQueryable<Pro, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Pro>?> GetListAsync(
        Expression<Func<Pro, bool>>? predicate = null,
        Func<IQueryable<Pro>, IOrderedQueryable<Pro>>? orderBy = null,
        Func<IQueryable<Pro>, IIncludableQueryable<Pro, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Pro> AddAsync(Pro pro);
    Task<Pro> UpdateAsync(Pro pro);
    Task<Pro> DeleteAsync(Pro pro, bool permanent = false);
 
}

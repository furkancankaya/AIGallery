using Core.Persistence.Paging;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.UsersService;

public interface IUserTempService
{
    Task<UserTemp?> GetAsync(
        Expression<Func<UserTemp, bool>> predicate,
        Func<IQueryable<UserTemp>, IIncludableQueryable<UserTemp, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<IPaginate<UserTemp>?> GetListAsync(
        Expression<Func<UserTemp, bool>>? predicate = null,
        Func<IQueryable<UserTemp>, IOrderedQueryable<UserTemp>>? orderBy = null,
        Func<IQueryable<UserTemp>, IIncludableQueryable<UserTemp, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<UserTemp> AddAsync(UserTemp user);
    Task<UserTemp> UpdateAsync(UserTemp user);
    Task<UserTemp> DeleteAsync(UserTemp user, bool permanent = false);
}

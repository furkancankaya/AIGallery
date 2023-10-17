using Core.Persistence.Paging;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.UsersService;

public interface IForgetPasswordService
{
    Task<ForgetPassword?> GetAsync(
        Expression<Func<ForgetPassword, bool>> predicate,
        Func<IQueryable<ForgetPassword>, IIncludableQueryable<ForgetPassword, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<IPaginate<ForgetPassword>?> GetListAsync(
        Expression<Func<ForgetPassword, bool>>? predicate = null,
        Func<IQueryable<ForgetPassword>, IOrderedQueryable<ForgetPassword>>? orderBy = null,
        Func<IQueryable<ForgetPassword>, IIncludableQueryable<ForgetPassword, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<ForgetPassword> AddAsync(ForgetPassword user);
    Task<ForgetPassword> UpdateAsync(ForgetPassword user);
    Task<ForgetPassword> DeleteAsync(ForgetPassword user, bool permanent = false);
}

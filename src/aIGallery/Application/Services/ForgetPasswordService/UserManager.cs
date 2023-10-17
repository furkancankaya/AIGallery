using Application.Features.Users.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.UsersService;

public class ForgetPasswordManager : IForgetPasswordService
{
    private readonly IForgetPasswordRepository _forgetPasswordRepository;
    private readonly UserBusinessRules _userBusinessRules;

    public ForgetPasswordManager(IForgetPasswordRepository forgetPasswordRepository, UserBusinessRules userBusinessRules)
    {
        _forgetPasswordRepository = forgetPasswordRepository;
        _userBusinessRules = userBusinessRules;
    }

    public async Task<ForgetPassword?> GetAsync(
        Expression<Func<ForgetPassword, bool>> predicate,
        Func<IQueryable<ForgetPassword>, IIncludableQueryable<ForgetPassword, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        ForgetPassword? user = await _forgetPasswordRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return user;
    }

    public async Task<IPaginate<ForgetPassword>?> GetListAsync(
        Expression<Func<ForgetPassword, bool>>? predicate = null,
        Func<IQueryable<ForgetPassword>, IOrderedQueryable<ForgetPassword>>? orderBy = null,
        Func<IQueryable<ForgetPassword>, IIncludableQueryable<ForgetPassword, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<ForgetPassword> userList = await _forgetPasswordRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return userList;
    }

    public async Task<ForgetPassword> AddAsync(ForgetPassword user)
    {
        await _userBusinessRules.UserEmailShouldNotExistsWhenInsert(user.Email);

        ForgetPassword addedUser = await _forgetPasswordRepository.AddAsync(user);

        return addedUser;
    }

    public async Task<ForgetPassword> UpdateAsync(ForgetPassword user)
    {

        ForgetPassword updatedUser = await _forgetPasswordRepository.UpdateAsync(user);

        return updatedUser;
    }

    public async Task<ForgetPassword> DeleteAsync(ForgetPassword user, bool permanent = false)
    {
        ForgetPassword deletedUser = await _forgetPasswordRepository.DeleteAsync(user);

        return deletedUser;
    }
}

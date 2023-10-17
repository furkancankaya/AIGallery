using Application.Features.Users.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.UsersService;

public class UserTempManager : IUserTempService
{
    private readonly IUserTempRepository _userTempRepository;
    private readonly UserBusinessRules _userBusinessRules;

    public UserTempManager(IUserTempRepository userTempRepository, UserBusinessRules userBusinessRules)
    {
        _userTempRepository = userTempRepository;
        _userBusinessRules = userBusinessRules;
    }

    public async Task<UserTemp?> GetAsync(
        Expression<Func<UserTemp, bool>> predicate,
        Func<IQueryable<UserTemp>, IIncludableQueryable<UserTemp, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        UserTemp? user = await _userTempRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return user;
    }

    public async Task<IPaginate<UserTemp>?> GetListAsync(
        Expression<Func<UserTemp, bool>>? predicate = null,
        Func<IQueryable<UserTemp>, IOrderedQueryable<UserTemp>>? orderBy = null,
        Func<IQueryable<UserTemp>, IIncludableQueryable<UserTemp, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<UserTemp> userList = await _userTempRepository.GetListAsync(
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

    public async Task<UserTemp> AddAsync(UserTemp user)
    {
        await _userBusinessRules.UserEmailShouldNotExistsWhenInsert(user.Email);

        UserTemp addedUser = await _userTempRepository.AddAsync(user);

        return addedUser;
    }

    public async Task<UserTemp> UpdateAsync(UserTemp user)
    {

        UserTemp updatedUser = await _userTempRepository.UpdateAsync(user);

        return updatedUser;
    }

    public async Task<UserTemp> DeleteAsync(UserTemp user, bool permanent = false)
    {
        UserTemp deletedUser = await _userTempRepository.DeleteAsync(user);

        return deletedUser;
    }
}
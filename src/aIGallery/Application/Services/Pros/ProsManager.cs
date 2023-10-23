using Application.Features.Pros.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Pros;

public class ProsManager : IProsService
{
    private readonly IProRepository _proRepository;
    private readonly ProBusinessRules _proBusinessRules;

    public ProsManager(IProRepository proRepository, ProBusinessRules proBusinessRules)
    {
        _proRepository = proRepository;
        _proBusinessRules = proBusinessRules;
    }

    public async Task<Pro?> GetAsync(
        Expression<Func<Pro, bool>> predicate,
        Func<IQueryable<Pro>, IIncludableQueryable<Pro, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Pro? pro = await _proRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return pro;
    }

    public async Task<IPaginate<Pro>?> GetListAsync(
        Expression<Func<Pro, bool>>? predicate = null,
        Func<IQueryable<Pro>, IOrderedQueryable<Pro>>? orderBy = null,
        Func<IQueryable<Pro>, IIncludableQueryable<Pro, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Pro> proList = await _proRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return proList;
    }

    public async Task<Pro> AddAsync(Pro pro)
    {
        Pro addedPro = await _proRepository.AddAsync(pro);

        return addedPro;
    }

    public async Task<Pro> UpdateAsync(Pro pro)
    {
        Pro updatedPro = await _proRepository.UpdateAsync(pro);

        return updatedPro;
    }

    public async Task<Pro> DeleteAsync(Pro pro, bool permanent = false)
    {
        Pro deletedPro = await _proRepository.DeleteAsync(pro);

        return deletedPro;
    }

  
}

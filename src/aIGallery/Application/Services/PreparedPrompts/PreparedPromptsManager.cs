using Application.Features.PreparedPrompts.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.PreparedPrompts;

public class PreparedPromptsManager : IPreparedPromptsService
{
    private readonly IPreparedPromptRepository _preparedPromptRepository;
    private readonly PreparedPromptBusinessRules _preparedPromptBusinessRules;

    public PreparedPromptsManager(IPreparedPromptRepository preparedPromptRepository, PreparedPromptBusinessRules preparedPromptBusinessRules)
    {
        _preparedPromptRepository = preparedPromptRepository;
        _preparedPromptBusinessRules = preparedPromptBusinessRules;
    }

    public async Task<PreparedPrompt?> GetAsync(
        Expression<Func<PreparedPrompt, bool>> predicate,
        Func<IQueryable<PreparedPrompt>, IIncludableQueryable<PreparedPrompt, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        PreparedPrompt? preparedPrompt = await _preparedPromptRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return preparedPrompt;
    }

    public async Task<IPaginate<PreparedPrompt>?> GetListAsync(
        Expression<Func<PreparedPrompt, bool>>? predicate = null,
        Func<IQueryable<PreparedPrompt>, IOrderedQueryable<PreparedPrompt>>? orderBy = null,
        Func<IQueryable<PreparedPrompt>, IIncludableQueryable<PreparedPrompt, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<PreparedPrompt> preparedPromptList = await _preparedPromptRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return preparedPromptList;
    }

    public async Task<PreparedPrompt> AddAsync(PreparedPrompt preparedPrompt)
    {
        PreparedPrompt addedPreparedPrompt = await _preparedPromptRepository.AddAsync(preparedPrompt);

        return addedPreparedPrompt;
    }

    public async Task<PreparedPrompt> UpdateAsync(PreparedPrompt preparedPrompt)
    {
        PreparedPrompt updatedPreparedPrompt = await _preparedPromptRepository.UpdateAsync(preparedPrompt);

        return updatedPreparedPrompt;
    }

    public async Task<PreparedPrompt> DeleteAsync(PreparedPrompt preparedPrompt, bool permanent = false)
    {
        PreparedPrompt deletedPreparedPrompt = await _preparedPromptRepository.DeleteAsync(preparedPrompt);

        return deletedPreparedPrompt;
    }
}

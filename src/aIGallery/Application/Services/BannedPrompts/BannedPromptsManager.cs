using Application.Features.BannedPrompts.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.BannedPrompts;

public class BannedPromptsManager : IBannedPromptsService
{
    private readonly IBannedPromptRepository _bannedPromptRepository;
    private readonly BannedPromptBusinessRules _bannedPromptBusinessRules;

    public BannedPromptsManager(IBannedPromptRepository bannedPromptRepository, BannedPromptBusinessRules bannedPromptBusinessRules)
    {
        _bannedPromptRepository = bannedPromptRepository;
        _bannedPromptBusinessRules = bannedPromptBusinessRules;
    }

    public async Task<BannedPrompt?> GetAsync(
        Expression<Func<BannedPrompt, bool>> predicate,
        Func<IQueryable<BannedPrompt>, IIncludableQueryable<BannedPrompt, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        BannedPrompt? bannedPrompt = await _bannedPromptRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return bannedPrompt;
    }

    public async Task<IPaginate<BannedPrompt>?> GetListAsync(
        Expression<Func<BannedPrompt, bool>>? predicate = null,
        Func<IQueryable<BannedPrompt>, IOrderedQueryable<BannedPrompt>>? orderBy = null,
        Func<IQueryable<BannedPrompt>, IIncludableQueryable<BannedPrompt, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<BannedPrompt> bannedPromptList = await _bannedPromptRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return bannedPromptList;
    }

    public async Task<BannedPrompt> AddAsync(BannedPrompt bannedPrompt)
    {
        BannedPrompt addedBannedPrompt = await _bannedPromptRepository.AddAsync(bannedPrompt);

        return addedBannedPrompt;
    }

    public async Task<BannedPrompt> UpdateAsync(BannedPrompt bannedPrompt)
    {
        BannedPrompt updatedBannedPrompt = await _bannedPromptRepository.UpdateAsync(bannedPrompt);

        return updatedBannedPrompt;
    }

    public async Task<BannedPrompt> DeleteAsync(BannedPrompt bannedPrompt, bool permanent = false)
    {
        BannedPrompt deletedBannedPrompt = await _bannedPromptRepository.DeleteAsync(bannedPrompt);

        return deletedBannedPrompt;
    }
}

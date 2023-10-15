using Application.Features.BannedPrompts.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.BannedPrompts.Rules;

public class BannedPromptBusinessRules : BaseBusinessRules
{
    private readonly IBannedPromptRepository _bannedPromptRepository;

    public BannedPromptBusinessRules(IBannedPromptRepository bannedPromptRepository)
    {
        _bannedPromptRepository = bannedPromptRepository;
    }

    public Task BannedPromptShouldExistWhenSelected(BannedPrompt? bannedPrompt)
    {
        if (bannedPrompt == null)
            throw new BusinessException(BannedPromptsBusinessMessages.BannedPromptNotExists);
        return Task.CompletedTask;
    }

    public async Task BannedPromptIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        BannedPrompt? bannedPrompt = await _bannedPromptRepository.GetAsync(
            predicate: bp => bp.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BannedPromptShouldExistWhenSelected(bannedPrompt);
    }
}
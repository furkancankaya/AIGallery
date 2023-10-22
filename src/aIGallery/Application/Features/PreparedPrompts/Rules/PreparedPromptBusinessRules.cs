using Application.Features.PreparedPrompts.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.PreparedPrompts.Rules;

public class PreparedPromptBusinessRules : BaseBusinessRules
{
    private readonly IPreparedPromptRepository _preparedPromptRepository;

    public PreparedPromptBusinessRules(IPreparedPromptRepository preparedPromptRepository)
    {
        _preparedPromptRepository = preparedPromptRepository;
    }

    public Task PreparedPromptShouldExistWhenSelected(PreparedPrompt? preparedPrompt)
    {
        if (preparedPrompt == null)
            throw new BusinessException(PreparedPromptsBusinessMessages.PreparedPromptNotExists);
        return Task.CompletedTask;
    }

    public async Task PreparedPromptIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        PreparedPrompt? preparedPrompt = await _preparedPromptRepository.GetAsync(
            predicate: pp => pp.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await PreparedPromptShouldExistWhenSelected(preparedPrompt);
    }
}
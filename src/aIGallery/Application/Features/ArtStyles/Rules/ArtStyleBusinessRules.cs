using Application.Features.ArtStyles.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.ArtStyles.Rules;

public class ArtStyleBusinessRules : BaseBusinessRules
{
    private readonly IArtStyleRepository _artStyleRepository;

    public ArtStyleBusinessRules(IArtStyleRepository artStyleRepository)
    {
        _artStyleRepository = artStyleRepository;
    }

    public Task ArtStyleShouldExistWhenSelected(ArtStyle? artStyle)
    {
        if (artStyle == null)
            throw new BusinessException(ArtStylesBusinessMessages.ArtStyleNotExists);
        return Task.CompletedTask;
    }

    public async Task ArtStyleIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        ArtStyle? artStyle = await _artStyleRepository.GetAsync(
            predicate: a => a.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ArtStyleShouldExistWhenSelected(artStyle);
    }
}
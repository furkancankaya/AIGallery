using Application.Features.Pros.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Pros.Rules;

public class ProBusinessRules : BaseBusinessRules
{
    private readonly IProRepository _proRepository;

    public ProBusinessRules(IProRepository proRepository)
    {
        _proRepository = proRepository;
    }

    public Task ProShouldExistWhenSelected(Pro? pro)
    {
        if (pro == null)
            throw new BusinessException(ProsBusinessMessages.ProNotExists);
        return Task.CompletedTask;
    }

    public async Task ProIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Pro? pro = await _proRepository.GetAsync(
            predicate: p => p.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ProShouldExistWhenSelected(pro);
    }

}
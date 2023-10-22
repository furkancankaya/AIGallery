using Application.Features.PreparedPrompts.Constants;
using Application.Features.PreparedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.PreparedPrompts.Commands.Delete;

public class DeletePreparedPromptCommand : IRequest<DeletedPreparedPromptResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPreparedPrompts";

    public class DeletePreparedPromptCommandHandler : IRequestHandler<DeletePreparedPromptCommand, DeletedPreparedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPreparedPromptRepository _preparedPromptRepository;
        private readonly PreparedPromptBusinessRules _preparedPromptBusinessRules;

        public DeletePreparedPromptCommandHandler(IMapper mapper, IPreparedPromptRepository preparedPromptRepository,
                                         PreparedPromptBusinessRules preparedPromptBusinessRules)
        {
            _mapper = mapper;
            _preparedPromptRepository = preparedPromptRepository;
            _preparedPromptBusinessRules = preparedPromptBusinessRules;
        }

        public async Task<DeletedPreparedPromptResponse> Handle(DeletePreparedPromptCommand request, CancellationToken cancellationToken)
        {
            PreparedPrompt? preparedPrompt = await _preparedPromptRepository.GetAsync(predicate: pp => pp.Id == request.Id, cancellationToken: cancellationToken);
            await _preparedPromptBusinessRules.PreparedPromptShouldExistWhenSelected(preparedPrompt);

            await _preparedPromptRepository.DeleteAsync(preparedPrompt!);

            DeletedPreparedPromptResponse response = _mapper.Map<DeletedPreparedPromptResponse>(preparedPrompt);
            return response;
        }
    }
}
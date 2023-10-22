using Application.Features.PreparedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.PreparedPrompts.Commands.Update;

public class UpdatePreparedPromptCommand : IRequest<UpdatedPreparedPromptResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Prompt { get; set; }
    public bool TextToImage { get; set; }
    public int Gender { get; set; }
    public int Sort { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPreparedPrompts";

    public class UpdatePreparedPromptCommandHandler : IRequestHandler<UpdatePreparedPromptCommand, UpdatedPreparedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPreparedPromptRepository _preparedPromptRepository;
        private readonly PreparedPromptBusinessRules _preparedPromptBusinessRules;

        public UpdatePreparedPromptCommandHandler(IMapper mapper, IPreparedPromptRepository preparedPromptRepository,
                                         PreparedPromptBusinessRules preparedPromptBusinessRules)
        {
            _mapper = mapper;
            _preparedPromptRepository = preparedPromptRepository;
            _preparedPromptBusinessRules = preparedPromptBusinessRules;
        }

        public async Task<UpdatedPreparedPromptResponse> Handle(UpdatePreparedPromptCommand request, CancellationToken cancellationToken)
        {
            PreparedPrompt? preparedPrompt = await _preparedPromptRepository.GetAsync(predicate: pp => pp.Id == request.Id, cancellationToken: cancellationToken);
            await _preparedPromptBusinessRules.PreparedPromptShouldExistWhenSelected(preparedPrompt);
            preparedPrompt = _mapper.Map(request, preparedPrompt);

            await _preparedPromptRepository.UpdateAsync(preparedPrompt!);

            UpdatedPreparedPromptResponse response = _mapper.Map<UpdatedPreparedPromptResponse>(preparedPrompt);
            return response;
        }
    }
}
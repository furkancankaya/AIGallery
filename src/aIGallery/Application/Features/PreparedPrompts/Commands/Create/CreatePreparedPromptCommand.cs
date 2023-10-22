using Application.Features.PreparedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.PreparedPrompts.Commands.Create;

public class CreatePreparedPromptCommand : IRequest<CreatedPreparedPromptResponse>, ICacheRemoverRequest
{
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Prompt { get; set; }
    public bool TextToImage { get; set; }
    public int Gender { get; set; }
    public int Sort { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPreparedPrompts";

    public class CreatePreparedPromptCommandHandler : IRequestHandler<CreatePreparedPromptCommand, CreatedPreparedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPreparedPromptRepository _preparedPromptRepository;
        private readonly PreparedPromptBusinessRules _preparedPromptBusinessRules;

        public CreatePreparedPromptCommandHandler(IMapper mapper, IPreparedPromptRepository preparedPromptRepository,
                                         PreparedPromptBusinessRules preparedPromptBusinessRules)
        {
            _mapper = mapper;
            _preparedPromptRepository = preparedPromptRepository;
            _preparedPromptBusinessRules = preparedPromptBusinessRules;
        }

        public async Task<CreatedPreparedPromptResponse> Handle(CreatePreparedPromptCommand request, CancellationToken cancellationToken)
        {
            PreparedPrompt preparedPrompt = _mapper.Map<PreparedPrompt>(request);

            await _preparedPromptRepository.AddAsync(preparedPrompt);

            CreatedPreparedPromptResponse response = _mapper.Map<CreatedPreparedPromptResponse>(preparedPrompt);
            return response;
        }
    }
}
using Application.Features.BannedPrompts.Constants;
using Application.Features.BannedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using MediatR;
using static Application.Features.BannedPrompts.Constants.BannedPromptsOperationClaims;

namespace Application.Features.BannedPrompts.Commands.Create;

public class CreateBannedPromptCommand : IRequest<CreatedBannedPromptResponse>, ISecuredRequest, ICacheRemoverRequest
{
    public string Prompt { get; set; }

    public string[] Roles => new[] { Admin, Write, BannedPromptsOperationClaims.Create };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetBannedPrompts";

    public class CreateBannedPromptCommandHandler : IRequestHandler<CreateBannedPromptCommand, CreatedBannedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBannedPromptRepository _bannedPromptRepository;
        private readonly BannedPromptBusinessRules _bannedPromptBusinessRules;

        public CreateBannedPromptCommandHandler(IMapper mapper, IBannedPromptRepository bannedPromptRepository,
                                         BannedPromptBusinessRules bannedPromptBusinessRules)
        {
            _mapper = mapper;
            _bannedPromptRepository = bannedPromptRepository;
            _bannedPromptBusinessRules = bannedPromptBusinessRules;
        }

        public async Task<CreatedBannedPromptResponse> Handle(CreateBannedPromptCommand request, CancellationToken cancellationToken)
        {
            BannedPrompt bannedPrompt = _mapper.Map<BannedPrompt>(request);

            await _bannedPromptRepository.AddAsync(bannedPrompt);

            CreatedBannedPromptResponse response = _mapper.Map<CreatedBannedPromptResponse>(bannedPrompt);
            return response;
        }
    }
}
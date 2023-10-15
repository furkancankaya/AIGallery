using Application.Features.BannedPrompts.Constants;
using Application.Features.BannedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using MediatR;
using static Application.Features.BannedPrompts.Constants.BannedPromptsOperationClaims;

namespace Application.Features.BannedPrompts.Commands.Update;

public class UpdateBannedPromptCommand : IRequest<UpdatedBannedPromptResponse>, ISecuredRequest, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public string Prompt { get; set; }

    public string[] Roles => new[] { Admin, Write, BannedPromptsOperationClaims.Update };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetBannedPrompts";

    public class UpdateBannedPromptCommandHandler : IRequestHandler<UpdateBannedPromptCommand, UpdatedBannedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBannedPromptRepository _bannedPromptRepository;
        private readonly BannedPromptBusinessRules _bannedPromptBusinessRules;

        public UpdateBannedPromptCommandHandler(IMapper mapper, IBannedPromptRepository bannedPromptRepository,
                                         BannedPromptBusinessRules bannedPromptBusinessRules)
        {
            _mapper = mapper;
            _bannedPromptRepository = bannedPromptRepository;
            _bannedPromptBusinessRules = bannedPromptBusinessRules;
        }

        public async Task<UpdatedBannedPromptResponse> Handle(UpdateBannedPromptCommand request, CancellationToken cancellationToken)
        {
            BannedPrompt? bannedPrompt = await _bannedPromptRepository.GetAsync(predicate: bp => bp.Id == request.Id, cancellationToken: cancellationToken);
            await _bannedPromptBusinessRules.BannedPromptShouldExistWhenSelected(bannedPrompt);
            bannedPrompt = _mapper.Map(request, bannedPrompt);

            await _bannedPromptRepository.UpdateAsync(bannedPrompt!);

            UpdatedBannedPromptResponse response = _mapper.Map<UpdatedBannedPromptResponse>(bannedPrompt);
            return response;
        }
    }
}
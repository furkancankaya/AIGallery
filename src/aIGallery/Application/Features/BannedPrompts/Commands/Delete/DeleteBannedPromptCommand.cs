using Application.Features.BannedPrompts.Constants;
using Application.Features.BannedPrompts.Constants;
using Application.Features.BannedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using MediatR;
using static Application.Features.BannedPrompts.Constants.BannedPromptsOperationClaims;

namespace Application.Features.BannedPrompts.Commands.Delete;

public class DeleteBannedPromptCommand : IRequest<DeletedBannedPromptResponse>, ISecuredRequest, ICacheRemoverRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Write, BannedPromptsOperationClaims.Delete };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetBannedPrompts";

    public class DeleteBannedPromptCommandHandler : IRequestHandler<DeleteBannedPromptCommand, DeletedBannedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBannedPromptRepository _bannedPromptRepository;
        private readonly BannedPromptBusinessRules _bannedPromptBusinessRules;

        public DeleteBannedPromptCommandHandler(IMapper mapper, IBannedPromptRepository bannedPromptRepository,
                                         BannedPromptBusinessRules bannedPromptBusinessRules)
        {
            _mapper = mapper;
            _bannedPromptRepository = bannedPromptRepository;
            _bannedPromptBusinessRules = bannedPromptBusinessRules;
        }

        public async Task<DeletedBannedPromptResponse> Handle(DeleteBannedPromptCommand request, CancellationToken cancellationToken)
        {
            BannedPrompt? bannedPrompt = await _bannedPromptRepository.GetAsync(predicate: bp => bp.Id == request.Id, cancellationToken: cancellationToken);
            await _bannedPromptBusinessRules.BannedPromptShouldExistWhenSelected(bannedPrompt);

            await _bannedPromptRepository.DeleteAsync(bannedPrompt!);

            DeletedBannedPromptResponse response = _mapper.Map<DeletedBannedPromptResponse>(bannedPrompt);
            return response;
        }
    }
}
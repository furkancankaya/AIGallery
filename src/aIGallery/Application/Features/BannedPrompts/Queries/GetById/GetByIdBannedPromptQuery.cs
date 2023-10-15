using Application.Features.BannedPrompts.Constants;
using Application.Features.BannedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.BannedPrompts.Constants.BannedPromptsOperationClaims;

namespace Application.Features.BannedPrompts.Queries.GetById;

public class GetByIdBannedPromptQuery : IRequest<GetByIdBannedPromptResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public class GetByIdBannedPromptQueryHandler : IRequestHandler<GetByIdBannedPromptQuery, GetByIdBannedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBannedPromptRepository _bannedPromptRepository;
        private readonly BannedPromptBusinessRules _bannedPromptBusinessRules;

        public GetByIdBannedPromptQueryHandler(IMapper mapper, IBannedPromptRepository bannedPromptRepository, BannedPromptBusinessRules bannedPromptBusinessRules)
        {
            _mapper = mapper;
            _bannedPromptRepository = bannedPromptRepository;
            _bannedPromptBusinessRules = bannedPromptBusinessRules;
        }

        public async Task<GetByIdBannedPromptResponse> Handle(GetByIdBannedPromptQuery request, CancellationToken cancellationToken)
        {
            BannedPrompt? bannedPrompt = await _bannedPromptRepository.GetAsync(predicate: bp => bp.Id == request.Id, cancellationToken: cancellationToken);
            await _bannedPromptBusinessRules.BannedPromptShouldExistWhenSelected(bannedPrompt);

            GetByIdBannedPromptResponse response = _mapper.Map<GetByIdBannedPromptResponse>(bannedPrompt);
            return response;
        }
    }
}
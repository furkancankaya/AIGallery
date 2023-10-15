using Application.Features.BannedPrompts.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using static Application.Features.BannedPrompts.Constants.BannedPromptsOperationClaims;

namespace Application.Features.BannedPrompts.Queries.GetList;

public class GetListBannedPromptQuery : IRequest<GetListResponse<GetListBannedPromptListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => new[] { Admin, Read };

    public bool BypassCache { get; }
    public string CacheKey => $"GetListBannedPrompts({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetBannedPrompts";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBannedPromptQueryHandler : IRequestHandler<GetListBannedPromptQuery, GetListResponse<GetListBannedPromptListItemDto>>
    {
        private readonly IBannedPromptRepository _bannedPromptRepository;
        private readonly IMapper _mapper;

        public GetListBannedPromptQueryHandler(IBannedPromptRepository bannedPromptRepository, IMapper mapper)
        {
            _bannedPromptRepository = bannedPromptRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBannedPromptListItemDto>> Handle(GetListBannedPromptQuery request, CancellationToken cancellationToken)
        {
            IPaginate<BannedPrompt> bannedPrompts = await _bannedPromptRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBannedPromptListItemDto> response = _mapper.Map<GetListResponse<GetListBannedPromptListItemDto>>(bannedPrompts);
            return response;
        }
    }
}
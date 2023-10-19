using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.TokenHistories.Queries.GetList;

public class GetListTokenHistoryQuery : IRequest<GetListResponse<GetListTokenHistoryListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListTokenHistories({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetTokenHistories";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListTokenHistoryQueryHandler : IRequestHandler<GetListTokenHistoryQuery, GetListResponse<GetListTokenHistoryListItemDto>>
    {
        private readonly ITokenHistoryRepository _tokenHistoryRepository;
        private readonly IMapper _mapper;

        public GetListTokenHistoryQueryHandler(ITokenHistoryRepository tokenHistoryRepository, IMapper mapper)
        {
            _tokenHistoryRepository = tokenHistoryRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListTokenHistoryListItemDto>> Handle(GetListTokenHistoryQuery request, CancellationToken cancellationToken)
        {
            IPaginate<TokenHistory> tokenHistories = await _tokenHistoryRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListTokenHistoryListItemDto> response = _mapper.Map<GetListResponse<GetListTokenHistoryListItemDto>>(tokenHistories);
            return response;
        }
    }
}
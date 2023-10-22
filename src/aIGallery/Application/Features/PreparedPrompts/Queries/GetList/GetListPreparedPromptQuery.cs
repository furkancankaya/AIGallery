using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.PreparedPrompts.Queries.GetList;

public class GetListPreparedPromptQuery : IRequest<GetListResponse<GetListPreparedPromptListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListPreparedPrompts({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetPreparedPrompts";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListPreparedPromptQueryHandler : IRequestHandler<GetListPreparedPromptQuery, GetListResponse<GetListPreparedPromptListItemDto>>
    {
        private readonly IPreparedPromptRepository _preparedPromptRepository;
        private readonly IMapper _mapper;

        public GetListPreparedPromptQueryHandler(IPreparedPromptRepository preparedPromptRepository, IMapper mapper)
        {
            _preparedPromptRepository = preparedPromptRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListPreparedPromptListItemDto>> Handle(GetListPreparedPromptQuery request, CancellationToken cancellationToken)
        {
            IPaginate<PreparedPrompt> preparedPrompts = await _preparedPromptRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListPreparedPromptListItemDto> response = _mapper.Map<GetListResponse<GetListPreparedPromptListItemDto>>(preparedPrompts);
            return response;
        }
    }
}
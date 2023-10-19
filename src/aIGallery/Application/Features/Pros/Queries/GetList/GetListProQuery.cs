using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.Pros.Queries.GetList;

public class GetListProQuery : IRequest<GetListResponse<GetListProListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListPros({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetPros";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListProQueryHandler : IRequestHandler<GetListProQuery, GetListResponse<GetListProListItemDto>>
    {
        private readonly IProRepository _proRepository;
        private readonly IMapper _mapper;

        public GetListProQueryHandler(IProRepository proRepository, IMapper mapper)
        {
            _proRepository = proRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListProListItemDto>> Handle(GetListProQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Pro> pros = await _proRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListProListItemDto> response = _mapper.Map<GetListResponse<GetListProListItemDto>>(pros);
            return response;
        }
    }
}
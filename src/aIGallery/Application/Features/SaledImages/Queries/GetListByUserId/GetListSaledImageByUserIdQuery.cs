using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.SaledImages.Queries.GetList;

public class GetListSaledImageByUserIdQuery : IRequest<GetListResponse<GetListSaledImageListItemDto>>, ICachableRequest
{
    public PageRequestWithUserId PageRequestWithUserId { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListSaledImages({PageRequestWithUserId.UserId},{PageRequestWithUserId.PageIndex},{PageRequestWithUserId.PageSize})";
    public string CacheGroupKey => "GetSaledImages";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListSaledImageByUserIdQueryHandler : IRequestHandler<GetListSaledImageByUserIdQuery, GetListResponse<GetListSaledImageListItemDto>>
    {
        private readonly ISaledImageRepository _saledImageRepository;
        private readonly IMapper _mapper;

        public GetListSaledImageByUserIdQueryHandler(ISaledImageRepository saledImageRepository, IMapper mapper)
        {
            _saledImageRepository = saledImageRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListSaledImageListItemDto>> Handle(GetListSaledImageByUserIdQuery request, CancellationToken cancellationToken)
        {
            IPaginate<SaledImage> saledImages = await _saledImageRepository.GetListAsync(
                predicate:x=>x.UserId==request.PageRequestWithUserId.UserId,
                include: x => x.Include(x => x.Image).Include(x => x.Image.Category).Include(x => x.Image.ArtStyle).Include(x => x.Image.User),
                index: request.PageRequestWithUserId.PageIndex,
                size: request.PageRequestWithUserId.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListSaledImageListItemDto> response = _mapper.Map<GetListResponse<GetListSaledImageListItemDto>>(saledImages);
            return response;
        }
    }
}
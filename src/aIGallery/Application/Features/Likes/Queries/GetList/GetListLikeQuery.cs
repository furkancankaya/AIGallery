using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Likes.Queries.GetList;

public class GetListLikeQuery : IRequest<GetListResponse<GetListLikeListItemDto>>, ICachableRequest
{
    public PageRequestWithUserId PageRequestWithUserId { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListLikes({PageRequestWithUserId.UserId},{PageRequestWithUserId.PageIndex},{PageRequestWithUserId.PageSize})";
    public string CacheGroupKey => "GetLikes";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListLikeQueryHandler : IRequestHandler<GetListLikeQuery, GetListResponse<GetListLikeListItemDto>>
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        public GetListLikeQueryHandler(ILikeRepository likeRepository, IMapper mapper)
        {
            _likeRepository = likeRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListLikeListItemDto>> Handle(GetListLikeQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Like> likes = await _likeRepository.GetListAsync(
               predicate: x => x.UserId == request.PageRequestWithUserId.UserId,
                include: x => x.Include(x => x.Image).Include(x=>x.Image.Category).Include(x => x.Image.ArtStyle).Include(x => x.Image.User),
                index: request.PageRequestWithUserId.PageIndex,
                size: request.PageRequestWithUserId.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListLikeListItemDto> response = _mapper.Map<GetListResponse<GetListLikeListItemDto>>(likes);
            return response;
        }
    }
}
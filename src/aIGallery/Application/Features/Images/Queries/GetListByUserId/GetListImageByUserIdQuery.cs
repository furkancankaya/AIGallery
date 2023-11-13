using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Images.Queries.GetList;

public class GetListImageByUserIdQuery : IRequest<GetListResponse<GetListImageListItemDto>>, ICachableRequest
{
    public PageRequestWithUserId PageRequestWithUserId { get; set; }
 
    public bool BypassCache { get; }
    public string CacheKey => $"GetListImagesByUserId({PageRequestWithUserId.UserId},{PageRequestWithUserId.PageIndex},{PageRequestWithUserId.PageSize})";
    public string CacheGroupKey => "GetImages";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListImageByUserIdQueryHandler : IRequestHandler<GetListImageByUserIdQuery, GetListResponse<GetListImageListItemDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetListImageByUserIdQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListImageListItemDto>> Handle(GetListImageByUserIdQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Image> images = await _imageRepository.GetListAsync(
                predicate:x=>x.UserId == request.PageRequestWithUserId.UserId,
                include: x=>x.Include(x=>x.User).Include(x=>x.Like).Include(x=>x.ArtStyle).Include(x=>x.Category).Include(x=>x.SaledImage).Include(x=>x.Like),
                index: request.PageRequestWithUserId.PageIndex,
                size: request.PageRequestWithUserId.PageSize,
                orderBy: x => x.OrderByDescending(x => x.CreatedDate),
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListImageListItemDto> response = _mapper.Map<GetListResponse<GetListImageListItemDto>>(images);
            return response;
        }
    }
}
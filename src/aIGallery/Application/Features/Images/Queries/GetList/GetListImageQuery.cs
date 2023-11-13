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

public class GetListImageQuery : IRequest<GetListResponse<GetListImageListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string CacheKey => $"GetListImages({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string CacheGroupKey => "GetImages";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListImageQueryHandler : IRequestHandler<GetListImageQuery, GetListResponse<GetListImageListItemDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetListImageQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListImageListItemDto>> Handle(GetListImageQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Image> images = await _imageRepository.GetListAsync(
                predicate:x=>x.Discover,
                include: x=>x.Include(x=>x.User).Include(x=>x.Like).Include(x=>x.ArtStyle).Include(x=>x.Category).Include(x=>x.SaledImage),
                orderBy: x=>x.OrderBy(x => x.Sort).ThenByDescending(x => x.UpdatedDate),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListImageListItemDto> response = _mapper.Map<GetListResponse<GetListImageListItemDto>>(images);
            return response;
        }
    }
}
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

public class GetTopImagesQuery : IRequest<GetListResponse<GetListImageListItemDto>> 
{
    public PageRequest PageRequest { get; set; }

    public class GetTopImagesQueryHandler : IRequestHandler<GetTopImagesQuery, GetListResponse<GetListImageListItemDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetTopImagesQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListImageListItemDto>> Handle(GetTopImagesQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Image> images = await _imageRepository.GetListAsync(
                predicate:x=>x.SaleStatus || x.Discover,
                orderBy:x=>x.OrderByDescending(y=>y.Like.Count),
                include:x=>x.Include(y=>y.User).Include(x => x.Like).Include(x=>x.SaledImage),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListImageListItemDto> response = _mapper.Map<GetListResponse<GetListImageListItemDto>>(images);
            return response;
        }
    }
}
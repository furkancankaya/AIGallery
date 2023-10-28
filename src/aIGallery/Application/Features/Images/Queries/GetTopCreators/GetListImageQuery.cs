using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Features.Images.Queries.GetTopCreators;

namespace Application.Features.Images.Queries.GetList;

public class GetTopCreatorsQuery : IRequest<GetListResponse<GetTopCreatorsListItemDto>>
{


    public class GetTopCreatorsQueryHandler : IRequestHandler<GetTopCreatorsQuery, GetListResponse<GetTopCreatorsListItemDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetTopCreatorsQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetTopCreatorsListItemDto>> Handle(GetTopCreatorsQuery request, CancellationToken cancellationToken)
        {
            int targetUserCount = 10; // Hedeflenen toplam kullanýcý sayýsý
            var uniqueUserImages = new List<Image>();

            for (int pageIndex = 0; uniqueUserImages.Count < targetUserCount; pageIndex++)
            {
                IPaginate<Image> images = await _imageRepository.GetListAsync(
                    include: x => x.Include(x => x.User).Include(x => x.Like),
                    orderBy: x => x.OrderBy(x => x.Like.Count),
                    index: pageIndex,
                    size: 10,
                    cancellationToken: cancellationToken
                );

                var uniqueImagesOnPage = images.Items
                    .GroupBy(img => img.UserId)
                    .Select(group => group.First())
                    .ToList();

                uniqueUserImages.AddRange(uniqueImagesOnPage);

                if (!images.HasNext)
                {
                    break; // Tüm sayfalarý kontrol ettik, döngüyü sonlandýr
                }
            }
            GetListResponse<GetTopCreatorsListItemDto> response = _mapper.Map<GetListResponse<GetTopCreatorsListItemDto>>(uniqueUserImages);
            return response;
        }
    }
}
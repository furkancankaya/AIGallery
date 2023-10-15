using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.ArtStyles.Queries.GetList;

public class GetListArtStyleQuery : IRequest<GetListResponse<GetListArtStyleListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListArtStyleQueryHandler : IRequestHandler<GetListArtStyleQuery, GetListResponse<GetListArtStyleListItemDto>>
    {
        private readonly IArtStyleRepository _artStyleRepository;
        private readonly IMapper _mapper;

        public GetListArtStyleQueryHandler(IArtStyleRepository artStyleRepository, IMapper mapper)
        {
            _artStyleRepository = artStyleRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListArtStyleListItemDto>> Handle(GetListArtStyleQuery request, CancellationToken cancellationToken)
        {
            IPaginate<ArtStyle> artStyles = await _artStyleRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListArtStyleListItemDto> response = _mapper.Map<GetListResponse<GetListArtStyleListItemDto>>(artStyles);
            return response;
        }
    }
}
using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
using Core.Application.Requests;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.ArtStyles.Queries.GetById;

public class GetByIdArtStyleQuery : IRequest<GetByIdArtStyleResponse>, ICachableRequest
{
    public Guid Id { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public string CacheKey => $"GetByIdArtStyle({PageIndex},{PageSize})";
    public string CacheGroupKey => "GetImages";
    public bool BypassCache { get; }
    public TimeSpan? SlidingExpiration { get; }

    public class GetByIdArtStyleQueryHandler : IRequestHandler<GetByIdArtStyleQuery, GetByIdArtStyleResponse>
    {
        private readonly IMapper _mapper;
        private readonly IArtStyleRepository _artStyleRepository;
        private readonly ArtStyleBusinessRules _artStyleBusinessRules;

        public GetByIdArtStyleQueryHandler(IMapper mapper, IArtStyleRepository artStyleRepository, ArtStyleBusinessRules artStyleBusinessRules)
        {
            _mapper = mapper;
            _artStyleRepository = artStyleRepository;
            _artStyleBusinessRules = artStyleBusinessRules;
        }

        public async Task<GetByIdArtStyleResponse> Handle(GetByIdArtStyleQuery request, CancellationToken cancellationToken)
        {
            ArtStyle? artStyle = await _artStyleRepository.GetAsync(
                predicate: a => a.Id == request.Id, 
                include: x => x.Include(x => x.Image.Where(x=>x.SaleStatus).Skip(0).Take(10)).ThenInclude(x => x.User),
                cancellationToken: cancellationToken);
            await _artStyleBusinessRules.ArtStyleShouldExistWhenSelected(artStyle);

            GetByIdArtStyleResponse response = _mapper.Map<GetByIdArtStyleResponse>(artStyle);
            return response;
        }
    }
}
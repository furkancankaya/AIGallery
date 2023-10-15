using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ArtStyles.Queries.GetById;

public class GetByIdArtStyleQuery : IRequest<GetByIdArtStyleResponse>
{
    public Guid Id { get; set; }

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
            ArtStyle? artStyle = await _artStyleRepository.GetAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);
            await _artStyleBusinessRules.ArtStyleShouldExistWhenSelected(artStyle);

            GetByIdArtStyleResponse response = _mapper.Map<GetByIdArtStyleResponse>(artStyle);
            return response;
        }
    }
}
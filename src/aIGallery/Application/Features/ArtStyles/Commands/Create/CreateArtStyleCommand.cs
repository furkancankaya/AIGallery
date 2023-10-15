using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ArtStyles.Commands.Create;

public class CreateArtStyleCommand : IRequest<CreatedArtStyleResponse>
{
    public string Logo { get; set; }
    public string Name { get; set; }

    public class CreateArtStyleCommandHandler : IRequestHandler<CreateArtStyleCommand, CreatedArtStyleResponse>
    {
        private readonly IMapper _mapper;
        private readonly IArtStyleRepository _artStyleRepository;
        private readonly ArtStyleBusinessRules _artStyleBusinessRules;

        public CreateArtStyleCommandHandler(IMapper mapper, IArtStyleRepository artStyleRepository,
                                         ArtStyleBusinessRules artStyleBusinessRules)
        {
            _mapper = mapper;
            _artStyleRepository = artStyleRepository;
            _artStyleBusinessRules = artStyleBusinessRules;
        }

        public async Task<CreatedArtStyleResponse> Handle(CreateArtStyleCommand request, CancellationToken cancellationToken)
        {
            ArtStyle artStyle = _mapper.Map<ArtStyle>(request);

            await _artStyleRepository.AddAsync(artStyle);

            CreatedArtStyleResponse response = _mapper.Map<CreatedArtStyleResponse>(artStyle);
            return response;
        }
    }
}
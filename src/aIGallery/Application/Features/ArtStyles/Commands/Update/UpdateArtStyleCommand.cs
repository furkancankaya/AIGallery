using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ArtStyles.Commands.Update;

public class UpdateArtStyleCommand : IRequest<UpdatedArtStyleResponse>
{
    public Guid Id { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }

    public class UpdateArtStyleCommandHandler : IRequestHandler<UpdateArtStyleCommand, UpdatedArtStyleResponse>
    {
        private readonly IMapper _mapper;
        private readonly IArtStyleRepository _artStyleRepository;
        private readonly ArtStyleBusinessRules _artStyleBusinessRules;

        public UpdateArtStyleCommandHandler(IMapper mapper, IArtStyleRepository artStyleRepository,
                                         ArtStyleBusinessRules artStyleBusinessRules)
        {
            _mapper = mapper;
            _artStyleRepository = artStyleRepository;
            _artStyleBusinessRules = artStyleBusinessRules;
        }

        public async Task<UpdatedArtStyleResponse> Handle(UpdateArtStyleCommand request, CancellationToken cancellationToken)
        {
            ArtStyle? artStyle = await _artStyleRepository.GetAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);
            await _artStyleBusinessRules.ArtStyleShouldExistWhenSelected(artStyle);
            artStyle = _mapper.Map(request, artStyle);

            await _artStyleRepository.UpdateAsync(artStyle!);

            UpdatedArtStyleResponse response = _mapper.Map<UpdatedArtStyleResponse>(artStyle);
            return response;
        }
    }
}
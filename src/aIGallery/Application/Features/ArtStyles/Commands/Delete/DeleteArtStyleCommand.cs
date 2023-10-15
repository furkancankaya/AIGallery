using Application.Features.ArtStyles.Constants;
using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ArtStyles.Commands.Delete;

public class DeleteArtStyleCommand : IRequest<DeletedArtStyleResponse>
{
    public Guid Id { get; set; }

    public class DeleteArtStyleCommandHandler : IRequestHandler<DeleteArtStyleCommand, DeletedArtStyleResponse>
    {
        private readonly IMapper _mapper;
        private readonly IArtStyleRepository _artStyleRepository;
        private readonly ArtStyleBusinessRules _artStyleBusinessRules;

        public DeleteArtStyleCommandHandler(IMapper mapper, IArtStyleRepository artStyleRepository,
                                         ArtStyleBusinessRules artStyleBusinessRules)
        {
            _mapper = mapper;
            _artStyleRepository = artStyleRepository;
            _artStyleBusinessRules = artStyleBusinessRules;
        }

        public async Task<DeletedArtStyleResponse> Handle(DeleteArtStyleCommand request, CancellationToken cancellationToken)
        {
            ArtStyle? artStyle = await _artStyleRepository.GetAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);
            await _artStyleBusinessRules.ArtStyleShouldExistWhenSelected(artStyle);

            await _artStyleRepository.DeleteAsync(artStyle!);

            DeletedArtStyleResponse response = _mapper.Map<DeletedArtStyleResponse>(artStyle);
            return response;
        }
    }
}
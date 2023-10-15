using Application.Features.ArtStyles.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.ArtStyles.Commands.Update;

public class UpdateArtStyleCommand : IRequest<UpdatedArtStyleResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetArtStyles";

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
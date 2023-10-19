using Application.Features.Pros.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.Pros.Commands.Update;

public class UpdateProCommand : IRequest<UpdatedProResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public int Type { get; set; }
    public int UserId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPros";

    public class UpdateProCommandHandler : IRequestHandler<UpdateProCommand, UpdatedProResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProRepository _proRepository;
        private readonly ProBusinessRules _proBusinessRules;

        public UpdateProCommandHandler(IMapper mapper, IProRepository proRepository,
                                         ProBusinessRules proBusinessRules)
        {
            _mapper = mapper;
            _proRepository = proRepository;
            _proBusinessRules = proBusinessRules;
        }

        public async Task<UpdatedProResponse> Handle(UpdateProCommand request, CancellationToken cancellationToken)
        {
            Pro? pro = await _proRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _proBusinessRules.ProShouldExistWhenSelected(pro);
            pro = _mapper.Map(request, pro);

            await _proRepository.UpdateAsync(pro!);

            UpdatedProResponse response = _mapper.Map<UpdatedProResponse>(pro);
            return response;
        }
    }
}
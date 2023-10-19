using Application.Features.Pros.Constants;
using Application.Features.Pros.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.Pros.Commands.Delete;

public class DeleteProCommand : IRequest<DeletedProResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPros";

    public class DeleteProCommandHandler : IRequestHandler<DeleteProCommand, DeletedProResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProRepository _proRepository;
        private readonly ProBusinessRules _proBusinessRules;

        public DeleteProCommandHandler(IMapper mapper, IProRepository proRepository,
                                         ProBusinessRules proBusinessRules)
        {
            _mapper = mapper;
            _proRepository = proRepository;
            _proBusinessRules = proBusinessRules;
        }

        public async Task<DeletedProResponse> Handle(DeleteProCommand request, CancellationToken cancellationToken)
        {
            Pro? pro = await _proRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _proBusinessRules.ProShouldExistWhenSelected(pro);

            await _proRepository.DeleteAsync(pro!);

            DeletedProResponse response = _mapper.Map<DeletedProResponse>(pro);
            return response;
        }
    }
}
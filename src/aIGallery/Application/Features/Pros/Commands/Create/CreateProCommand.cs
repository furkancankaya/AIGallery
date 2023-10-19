using Application.Features.Pros.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.Pros.Commands.Create;

public class CreateProCommand : IRequest<CreatedProResponse>, ICacheRemoverRequest
{
    public int Type { get; set; }
    public int UserId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetPros";

    public class CreateProCommandHandler : IRequestHandler<CreateProCommand, CreatedProResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProRepository _proRepository;
        private readonly ProBusinessRules _proBusinessRules;

        public CreateProCommandHandler(IMapper mapper, IProRepository proRepository,
                                         ProBusinessRules proBusinessRules)
        {
            _mapper = mapper;
            _proRepository = proRepository;
            _proBusinessRules = proBusinessRules;
        }

        public async Task<CreatedProResponse> Handle(CreateProCommand request, CancellationToken cancellationToken)
        {
            Pro pro = _mapper.Map<Pro>(request);

            await _proRepository.AddAsync(pro);

            CreatedProResponse response = _mapper.Map<CreatedProResponse>(pro);
            return response;
        }
    }
}
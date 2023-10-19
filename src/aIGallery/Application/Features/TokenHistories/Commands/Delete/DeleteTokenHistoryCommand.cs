using Application.Features.TokenHistories.Constants;
using Application.Features.TokenHistories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;

namespace Application.Features.TokenHistories.Commands.Delete;

public class DeleteTokenHistoryCommand : IRequest<DeletedTokenHistoryResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetTokenHistories";

    public class DeleteTokenHistoryCommandHandler : IRequestHandler<DeleteTokenHistoryCommand, DeletedTokenHistoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHistoryRepository _tokenHistoryRepository;
        private readonly TokenHistoryBusinessRules _tokenHistoryBusinessRules;

        public DeleteTokenHistoryCommandHandler(IMapper mapper, ITokenHistoryRepository tokenHistoryRepository,
                                         TokenHistoryBusinessRules tokenHistoryBusinessRules)
        {
            _mapper = mapper;
            _tokenHistoryRepository = tokenHistoryRepository;
            _tokenHistoryBusinessRules = tokenHistoryBusinessRules;
        }

        public async Task<DeletedTokenHistoryResponse> Handle(DeleteTokenHistoryCommand request, CancellationToken cancellationToken)
        {
            TokenHistory? tokenHistory = await _tokenHistoryRepository.GetAsync(predicate: th => th.Id == request.Id, cancellationToken: cancellationToken);
            await _tokenHistoryBusinessRules.TokenHistoryShouldExistWhenSelected(tokenHistory);

            await _tokenHistoryRepository.DeleteAsync(tokenHistory!);

            DeletedTokenHistoryResponse response = _mapper.Map<DeletedTokenHistoryResponse>(tokenHistory);
            return response;
        }
    }
}
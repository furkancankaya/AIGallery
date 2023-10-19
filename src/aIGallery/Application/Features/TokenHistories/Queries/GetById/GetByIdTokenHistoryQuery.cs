using Application.Features.TokenHistories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.TokenHistories.Queries.GetById;

public class GetByIdTokenHistoryQuery : IRequest<GetByIdTokenHistoryResponse>
{
    public Guid Id { get; set; }

    public class GetByIdTokenHistoryQueryHandler : IRequestHandler<GetByIdTokenHistoryQuery, GetByIdTokenHistoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHistoryRepository _tokenHistoryRepository;
        private readonly TokenHistoryBusinessRules _tokenHistoryBusinessRules;

        public GetByIdTokenHistoryQueryHandler(IMapper mapper, ITokenHistoryRepository tokenHistoryRepository, TokenHistoryBusinessRules tokenHistoryBusinessRules)
        {
            _mapper = mapper;
            _tokenHistoryRepository = tokenHistoryRepository;
            _tokenHistoryBusinessRules = tokenHistoryBusinessRules;
        }

        public async Task<GetByIdTokenHistoryResponse> Handle(GetByIdTokenHistoryQuery request, CancellationToken cancellationToken)
        {
            TokenHistory? tokenHistory = await _tokenHistoryRepository.GetAsync(predicate: th => th.Id == request.Id, cancellationToken: cancellationToken);
            await _tokenHistoryBusinessRules.TokenHistoryShouldExistWhenSelected(tokenHistory);

            GetByIdTokenHistoryResponse response = _mapper.Map<GetByIdTokenHistoryResponse>(tokenHistory);
            return response;
        }
    }
}
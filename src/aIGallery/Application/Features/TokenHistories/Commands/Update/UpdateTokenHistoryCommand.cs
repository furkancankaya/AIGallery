using Application.Features.TokenHistories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;
using Application.Features.Auth.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;

namespace Application.Features.TokenHistories.Commands.Update;

public class UpdateTokenHistoryCommand : IRequest<UpdatedTokenHistoryResponse>, ICacheRemoverRequest
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public string Price { get; set; }
    public int UserId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetTokenHistories";

    public class UpdateTokenHistoryCommandHandler : IRequestHandler<UpdateTokenHistoryCommand, UpdatedTokenHistoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHistoryRepository _tokenHistoryRepository;
        private readonly TokenHistoryBusinessRules _tokenHistoryBusinessRules;
        private readonly IUserRepository _userRepository;

        public UpdateTokenHistoryCommandHandler(IMapper mapper, ITokenHistoryRepository tokenHistoryRepository,
                                         TokenHistoryBusinessRules tokenHistoryBusinessRules, IUserRepository userRepository)
        {
            _mapper = mapper;
            _tokenHistoryRepository = tokenHistoryRepository;
            _tokenHistoryBusinessRules = tokenHistoryBusinessRules;
            _userRepository = userRepository;
        }

        public async Task<UpdatedTokenHistoryResponse> Handle(UpdateTokenHistoryCommand request, CancellationToken cancellationToken)
        {
            TokenHistory? tokenHistory = await _tokenHistoryRepository.GetAsync(predicate: th => th.Id == request.Id, cancellationToken: cancellationToken);
            await _tokenHistoryBusinessRules.TokenHistoryShouldExistWhenSelected(tokenHistory);
            tokenHistory = _mapper.Map(request, tokenHistory);

            User? user = await _userRepository.GetAsync(predicate: i => i.Id == request.UserId, cancellationToken: cancellationToken);

            if (user != null)
            {
                user.Token += request.Amount;
                await _tokenHistoryRepository.UpdateAsync(tokenHistory!);
                await _userRepository.UpdateAsync(user);
            }
            else
            {
                throw new BusinessException(AuthMessages.UserDontExists);
            }


            UpdatedTokenHistoryResponse response = _mapper.Map<UpdatedTokenHistoryResponse>(tokenHistory);
            return response;
        }
    }
}
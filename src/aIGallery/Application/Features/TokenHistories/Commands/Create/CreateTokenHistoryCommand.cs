using Application.Features.TokenHistories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Pipelines.Caching;
using MediatR;
using Core.Security.Entities;
using Application.Features.Users.Commands.UpdateFromAuth;
using Application.Features.TokenHistories.Constants;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Application.Features.Auth.Constants;
using Application.Features.Users.Rules;

namespace Application.Features.TokenHistories.Commands.Create;

public class CreateTokenHistoryCommand : IRequest<CreatedTokenHistoryResponse>, ICacheRemoverRequest
{
    
    public int Amount { get; set; }
    public int Price { get; set; }
    public int UserId { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string CacheGroupKey => "GetTokenHistories";

    public class CreateTokenHistoryCommandHandler : IRequestHandler<CreateTokenHistoryCommand, CreatedTokenHistoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHistoryRepository _tokenHistoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly TokenHistoryBusinessRules _tokenHistoryBusinessRules;
        private readonly UserBusinessRules _userBusinessRules;
        public CreateTokenHistoryCommandHandler(IMapper mapper, ITokenHistoryRepository tokenHistoryRepository,
                                         TokenHistoryBusinessRules tokenHistoryBusinessRules, IUserRepository userRepository, UserBusinessRules userBusinessRules)
        {
            _mapper = mapper;
            _tokenHistoryRepository = tokenHistoryRepository;
            _tokenHistoryBusinessRules = tokenHistoryBusinessRules;
            _userRepository = userRepository;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<CreatedTokenHistoryResponse> Handle(CreateTokenHistoryCommand request, CancellationToken cancellationToken)
        {
            TokenHistory tokenHistory = _mapper.Map<TokenHistory>(request);
            

            User? user = await _userRepository.GetAsync(predicate: i => i.Id == request.UserId, cancellationToken: cancellationToken);


            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);


            user.Token += request.Amount;
            await _tokenHistoryRepository.AddAsync(tokenHistory);
            await _userRepository.UpdateAsync(user);

            CreatedTokenHistoryResponse response = _mapper.Map<CreatedTokenHistoryResponse>(tokenHistory);
            return response;
        }
    }
}
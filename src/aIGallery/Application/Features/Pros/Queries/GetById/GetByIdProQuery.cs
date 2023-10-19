using Application.Features.Pros.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Pros.Queries.GetById;

public class GetByIdProQuery : IRequest<GetByIdProResponse>
{
    public Guid Id { get; set; }

    public class GetByIdProQueryHandler : IRequestHandler<GetByIdProQuery, GetByIdProResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProRepository _proRepository;
        private readonly ProBusinessRules _proBusinessRules;

        public GetByIdProQueryHandler(IMapper mapper, IProRepository proRepository, ProBusinessRules proBusinessRules)
        {
            _mapper = mapper;
            _proRepository = proRepository;
            _proBusinessRules = proBusinessRules;
        }

        public async Task<GetByIdProResponse> Handle(GetByIdProQuery request, CancellationToken cancellationToken)
        {
            Pro? pro = await _proRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _proBusinessRules.ProShouldExistWhenSelected(pro);

            GetByIdProResponse response = _mapper.Map<GetByIdProResponse>(pro);
            return response;
        }
    }
}
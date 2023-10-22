using Application.Features.PreparedPrompts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.PreparedPrompts.Queries.GetById;

public class GetByIdPreparedPromptQuery : IRequest<GetByIdPreparedPromptResponse>
{
    public Guid Id { get; set; }

    public class GetByIdPreparedPromptQueryHandler : IRequestHandler<GetByIdPreparedPromptQuery, GetByIdPreparedPromptResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPreparedPromptRepository _preparedPromptRepository;
        private readonly PreparedPromptBusinessRules _preparedPromptBusinessRules;

        public GetByIdPreparedPromptQueryHandler(IMapper mapper, IPreparedPromptRepository preparedPromptRepository, PreparedPromptBusinessRules preparedPromptBusinessRules)
        {
            _mapper = mapper;
            _preparedPromptRepository = preparedPromptRepository;
            _preparedPromptBusinessRules = preparedPromptBusinessRules;
        }

        public async Task<GetByIdPreparedPromptResponse> Handle(GetByIdPreparedPromptQuery request, CancellationToken cancellationToken)
        {
            PreparedPrompt? preparedPrompt = await _preparedPromptRepository.GetAsync(predicate: pp => pp.Id == request.Id, cancellationToken: cancellationToken);
            await _preparedPromptBusinessRules.PreparedPromptShouldExistWhenSelected(preparedPrompt);

            GetByIdPreparedPromptResponse response = _mapper.Map<GetByIdPreparedPromptResponse>(preparedPrompt);
            return response;
        }
    }
}
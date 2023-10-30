using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Core.Security.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.GetList;

public class GetTopCreatorsQuery : IRequest<GetListResponse<GetListUserListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public GetTopCreatorsQuery()
    {
        PageRequest = new PageRequest { PageIndex = 0, PageSize = 10 };
    }

    public GetTopCreatorsQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }

    public class GetTopCreatorsQueryHandler : IRequestHandler<GetTopCreatorsQuery, GetListResponse<GetListUserListItemDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetTopCreatorsQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListUserListItemDto>> Handle(GetTopCreatorsQuery request, CancellationToken cancellationToken)
        {
            IPaginate<User> users = await _userRepository.GetListAsync(
            orderBy: x => x.OrderByDescending(u => u.Images.SelectMany(i => i.Like).Count()),
            index: 0,
            size: 10,
            cancellationToken: cancellationToken
            );

            GetListResponse<GetListUserListItemDto> response = _mapper.Map<GetListResponse<GetListUserListItemDto>>(users);
            return response;
        }
    }
}

using Application.Features.Users.Queries.GetList;
using Core.Application.Dtos;

namespace Application.Features.Pros.Queries.GetList;

public class GetListProListItemDto : IDto
{
    public Guid Id { get; set; }
    public int Type { get; set; }
    public GetListUserListUserDto User { get; set; }
}
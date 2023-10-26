using Core.Application.Dtos;
using Domain.Entities;

namespace Application.Features.Likes.Queries.GetList;

public class GetListLikeListItemDto : IDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid ImageId { get; set; }
    public LikeImageDto Image { get; set; }
}
using Application.Features.Likes.Queries.GetList;
using Core.Application.Dtos;

namespace Application.Features.SaledImages.Queries.GetList;

public class GetListSaledImageListItemDto : IDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid ImageId { get; set; }
    public SaledImageDto Image { get; set; }

}
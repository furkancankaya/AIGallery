using Core.Application.Dtos;

namespace Application.Features.SaledImages.Queries.GetList;

public class GetListSaledImageListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }
}
using Core.Application.Dtos;

namespace Application.Features.ArtStyles.Queries.GetList;

public class GetListArtStyleListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
}
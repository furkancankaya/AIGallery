using Core.Application.Dtos;

namespace Application.Features.ArtStyles.Queries.GetList;

public class GetListArtStyleListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string Prompt { get; set; }
    public int Sort { get; set; }
}
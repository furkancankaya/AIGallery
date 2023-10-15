using Core.Application.Responses;

namespace Application.Features.ArtStyles.Queries.GetById;

public class GetByIdArtStyleResponse : IResponse
{
    public Guid Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
}
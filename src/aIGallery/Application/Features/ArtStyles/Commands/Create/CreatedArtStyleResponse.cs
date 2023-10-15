using Core.Application.Responses;

namespace Application.Features.ArtStyles.Commands.Create;

public class CreatedArtStyleResponse : IResponse
{
    public Guid Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
}
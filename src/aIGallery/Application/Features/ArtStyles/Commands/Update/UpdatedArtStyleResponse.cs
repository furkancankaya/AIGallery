using Core.Application.Responses;

namespace Application.Features.ArtStyles.Commands.Update;

public class UpdatedArtStyleResponse : IResponse
{
    public Guid Id { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string Prompt { get; set; }
    public int Sort { get; set; }
}
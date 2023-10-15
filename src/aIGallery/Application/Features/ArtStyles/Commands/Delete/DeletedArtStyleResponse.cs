using Core.Application.Responses;

namespace Application.Features.ArtStyles.Commands.Delete;

public class DeletedArtStyleResponse : IResponse
{
    public Guid Id { get; set; }
}
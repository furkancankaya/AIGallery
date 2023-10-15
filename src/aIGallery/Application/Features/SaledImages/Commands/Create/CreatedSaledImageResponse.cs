using Core.Application.Responses;

namespace Application.Features.SaledImages.Commands.Create;

public class CreatedSaledImageResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }
}
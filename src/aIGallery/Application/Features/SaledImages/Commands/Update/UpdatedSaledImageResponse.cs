using Core.Application.Responses;

namespace Application.Features.SaledImages.Commands.Update;

public class UpdatedSaledImageResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }
}
using Core.Application.Responses;

namespace Application.Features.SaledImages.Queries.GetById;

public class GetByIdSaledImageResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }
}
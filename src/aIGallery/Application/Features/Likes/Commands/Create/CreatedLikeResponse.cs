using Core.Application.Responses;

namespace Application.Features.Likes.Commands.Create;

public class CreatedLikeResponse : IResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid ImageId { get; set; }
}
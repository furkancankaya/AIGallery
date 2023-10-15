using Core.Application.Responses;

namespace Application.Features.Likes.Queries.GetById;

public class GetByIdLikeResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }
}
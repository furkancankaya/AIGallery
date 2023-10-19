using Core.Application.Responses;

namespace Application.Features.Pros.Queries.GetById;

public class GetByIdProResponse : IResponse
{
    public Guid Id { get; set; }
    public int Type { get; set; }
    public int UserId { get; set; }
}
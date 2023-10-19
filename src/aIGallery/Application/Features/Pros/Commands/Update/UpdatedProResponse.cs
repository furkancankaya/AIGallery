using Core.Application.Responses;

namespace Application.Features.Pros.Commands.Update;

public class UpdatedProResponse : IResponse
{
    public Guid Id { get; set; }
    public int Type { get; set; }
    public int UserId { get; set; }
}
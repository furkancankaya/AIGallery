using Core.Application.Responses;

namespace Application.Features.Pros.Commands.Create;

public class CreatedProResponse : IResponse
{
    public Guid Id { get; set; }
    public int Type { get; set; }
    public int UserId { get; set; }
}
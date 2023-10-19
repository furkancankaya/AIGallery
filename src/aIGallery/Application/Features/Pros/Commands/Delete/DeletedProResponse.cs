using Core.Application.Responses;

namespace Application.Features.Pros.Commands.Delete;

public class DeletedProResponse : IResponse
{
    public Guid Id { get; set; }
}
using Core.Application.Responses;

namespace Application.Features.PreparedPrompts.Commands.Delete;

public class DeletedPreparedPromptResponse : IResponse
{
    public Guid Id { get; set; }
}
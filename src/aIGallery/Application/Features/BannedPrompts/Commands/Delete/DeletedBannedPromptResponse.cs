using Core.Application.Responses;

namespace Application.Features.BannedPrompts.Commands.Delete;

public class DeletedBannedPromptResponse : IResponse
{
    public Guid Id { get; set; }
}
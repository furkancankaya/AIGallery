using Core.Application.Responses;

namespace Application.Features.BannedPrompts.Commands.Update;

public class UpdatedBannedPromptResponse : IResponse
{
    public Guid Id { get; set; }
    public string Prompt { get; set; }
}
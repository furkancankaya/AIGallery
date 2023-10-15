using Core.Application.Responses;

namespace Application.Features.BannedPrompts.Commands.Create;

public class CreatedBannedPromptResponse : IResponse
{
    public Guid Id { get; set; }
    public string Prompt { get; set; }
}
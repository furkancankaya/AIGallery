using Core.Application.Responses;

namespace Application.Features.BannedPrompts.Queries.GetById;

public class GetByIdBannedPromptResponse : IResponse
{
    public Guid Id { get; set; }
    public string Prompt { get; set; }
}
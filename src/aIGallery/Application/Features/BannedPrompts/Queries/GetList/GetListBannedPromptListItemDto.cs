using Core.Application.Dtos;

namespace Application.Features.BannedPrompts.Queries.GetList;

public class GetListBannedPromptListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Prompt { get; set; }
}
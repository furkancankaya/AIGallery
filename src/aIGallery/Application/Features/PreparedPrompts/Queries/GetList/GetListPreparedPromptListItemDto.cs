using Core.Application.Dtos;

namespace Application.Features.PreparedPrompts.Queries.GetList;

public class GetListPreparedPromptListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Prompt { get; set; }
    public bool TextToImage { get; set; }
    public int Gender { get; set; }
    public int Sort { get; set; }
}
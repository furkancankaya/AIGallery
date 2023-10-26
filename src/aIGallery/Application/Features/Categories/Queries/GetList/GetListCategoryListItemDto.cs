using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public int Sort { get; set; }
    public List<CategoryImageDtos> Image { get; set; }
}
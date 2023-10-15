using Core.Application.Dtos;
using Domain.Entities;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public List<Image> Image { get; set; }
}
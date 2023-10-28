using Application.Features.Categories.Queries.GetList;
using Core.Application.Responses;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public int Sort { get; set; }
    public List<CategoryImageDtos> Image { get; set; }

}
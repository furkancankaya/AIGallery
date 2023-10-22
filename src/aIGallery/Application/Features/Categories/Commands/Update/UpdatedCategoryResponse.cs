using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Update;

public class UpdatedCategoryResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public int Sort { get; set; }
}
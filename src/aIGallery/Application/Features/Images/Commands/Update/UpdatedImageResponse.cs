using Core.Application.Responses;

namespace Application.Features.Images.Commands.Update;

public class UpdatedImageResponse : IResponse
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public string? Prompt { get; set; }
    public Guid? ArtStyleId { get; set; }
    public int UserId { get; set; }
    public Guid? CategoryId { get; set; }
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }
    public bool Blocked { get; set; }
}
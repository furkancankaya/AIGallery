using Application.Features.Users.Queries.GetList;
using Core.Application.Dtos;
using Core.Security.Entities;

namespace Application.Features.Images.Queries.GetList;

public class GetListImageListItemDto : IDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public string? Prompt { get; set; }
    public Guid? ArtStyleId { get; set; }
    public string ArtStyleName { get; set; }
    public GetListUserListUserDto User { get; set; }
    public Guid? CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }
    public bool Blocked { get; set; }
    public List<int> LikedUsers { get; set; }
    public List<int> BuyedUsers { get; set; }
 
}
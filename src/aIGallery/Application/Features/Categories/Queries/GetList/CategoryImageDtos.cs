using Application.Features.Users.Queries.GetList;
using Core.Security.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.GetList;
public class CategoryImageDtos
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public string? Prompt { get; set; }
    public Guid? ArtStyleId { get; set; }
    public string ArtStyleName { get; set; }
    public int UserId { get; set; }
    public GetListUserListUserDto User { get; set; }
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }
    public bool Blocked { get; set; }
    public List<int> LikedUsers { get; set; }
    public List<int> BuyedUsers { get; set; }
}

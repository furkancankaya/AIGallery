﻿using Core.Security.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.GetList;
public class ImageDtos
{
    public string ImageUrl { get; set; }
    public string? Prompt { get; set; }
    public Guid? ArtStyleId { get; set; }
    public int UserId { get; set; }
    
    public string? ImgToImg { get; set; }
    public bool Discover { get; set; }
    public bool SaleStatus { get; set; }
    public int SalePrice { get; set; }
    public bool Blocked { get; set; }
    public virtual User? User { get; set; }
    public virtual ArtStyle? ArtStyle { get; set; }
   
    public virtual ICollection<Like> Like { get; set; }
    public virtual ICollection<SaledImage> SaledImage { get; set; }
}

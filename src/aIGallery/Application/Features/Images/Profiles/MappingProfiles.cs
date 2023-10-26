using Application.Features.Images.Commands.Create;
using Application.Features.Images.Commands.Delete;
using Application.Features.Images.Commands.Update;
using Application.Features.Images.Queries.GetById;
using Application.Features.Images.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;
using Application.Features.Users.Queries.GetList;
using Core.Security.Entities;

namespace Application.Features.Images.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Image, CreateImageCommand>().ReverseMap();
        CreateMap<Image, CreatedImageResponse>().ReverseMap();
        CreateMap<Image, UpdateImageCommand>().ReverseMap();
        CreateMap<Image, UpdatedImageResponse>().ReverseMap();
        CreateMap<Image, DeleteImageCommand>().ReverseMap();
        CreateMap<Image, DeletedImageResponse>().ReverseMap();
        CreateMap<Image, GetByIdImageResponse>().ReverseMap();
        CreateMap<Image, GetListImageListItemDto>()
        .ForMember(destinationMember: c => c.LikedUsers, memberOptions: opt => opt.MapFrom(c => c.Like.Select(x=>x.UserId)))
 

            .ReverseMap();
        //alt 3 ünü mapleme için ben yazdým
        CreateMap<User, GetListUserListUserDto>().ReverseMap();
        CreateMap<Image, GetListUserListUserDto>().ReverseMap();
        CreateMap<GetListUserListUserDto, GetListImageListItemDto>().ReverseMap();
        //
        CreateMap<IPaginate<Image>, GetListResponse<GetListImageListItemDto>>().ReverseMap();
    }
}
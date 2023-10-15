using Application.Features.ArtStyles.Commands.Create;
using Application.Features.ArtStyles.Commands.Delete;
using Application.Features.ArtStyles.Commands.Update;
using Application.Features.ArtStyles.Queries.GetById;
using Application.Features.ArtStyles.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.ArtStyles.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ArtStyle, CreateArtStyleCommand>().ReverseMap();
        CreateMap<ArtStyle, CreatedArtStyleResponse>().ReverseMap();
        CreateMap<ArtStyle, UpdateArtStyleCommand>().ReverseMap();
        CreateMap<ArtStyle, UpdatedArtStyleResponse>().ReverseMap();
        CreateMap<ArtStyle, DeleteArtStyleCommand>().ReverseMap();
        CreateMap<ArtStyle, DeletedArtStyleResponse>().ReverseMap();
        CreateMap<ArtStyle, GetByIdArtStyleResponse>().ReverseMap();
        CreateMap<ArtStyle, GetListArtStyleListItemDto>().ReverseMap();
        CreateMap<IPaginate<ArtStyle>, GetListResponse<GetListArtStyleListItemDto>>().ReverseMap();
    }
}
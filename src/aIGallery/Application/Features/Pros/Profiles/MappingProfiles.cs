using Application.Features.Pros.Commands.Create;
using Application.Features.Pros.Commands.Delete;
using Application.Features.Pros.Commands.Update;
using Application.Features.Pros.Queries.GetById;
using Application.Features.Pros.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.Pros.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pro, CreateProCommand>().ReverseMap();
        CreateMap<Pro, CreatedProResponse>().ReverseMap();
        CreateMap<Pro, UpdateProCommand>().ReverseMap();
        CreateMap<Pro, UpdatedProResponse>().ReverseMap();
        CreateMap<Pro, DeleteProCommand>().ReverseMap();
        CreateMap<Pro, DeletedProResponse>().ReverseMap();
        CreateMap<Pro, GetByIdProResponse>().ReverseMap();
        CreateMap<Pro, GetListProListItemDto>().ReverseMap();
        CreateMap<IPaginate<Pro>, GetListResponse<GetListProListItemDto>>().ReverseMap();
    }
}
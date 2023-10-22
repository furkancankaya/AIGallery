using Application.Features.PreparedPrompts.Commands.Create;
using Application.Features.PreparedPrompts.Commands.Delete;
using Application.Features.PreparedPrompts.Commands.Update;
using Application.Features.PreparedPrompts.Queries.GetById;
using Application.Features.PreparedPrompts.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.PreparedPrompts.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<PreparedPrompt, CreatePreparedPromptCommand>().ReverseMap();
        CreateMap<PreparedPrompt, CreatedPreparedPromptResponse>().ReverseMap();
        CreateMap<PreparedPrompt, UpdatePreparedPromptCommand>().ReverseMap();
        CreateMap<PreparedPrompt, UpdatedPreparedPromptResponse>().ReverseMap();
        CreateMap<PreparedPrompt, DeletePreparedPromptCommand>().ReverseMap();
        CreateMap<PreparedPrompt, DeletedPreparedPromptResponse>().ReverseMap();
        CreateMap<PreparedPrompt, GetByIdPreparedPromptResponse>().ReverseMap();
        CreateMap<PreparedPrompt, GetListPreparedPromptListItemDto>().ReverseMap();
        CreateMap<IPaginate<PreparedPrompt>, GetListResponse<GetListPreparedPromptListItemDto>>().ReverseMap();
    }
}
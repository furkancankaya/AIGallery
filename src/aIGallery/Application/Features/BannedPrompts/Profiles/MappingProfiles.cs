using Application.Features.BannedPrompts.Commands.Create;
using Application.Features.BannedPrompts.Commands.Delete;
using Application.Features.BannedPrompts.Commands.Update;
using Application.Features.BannedPrompts.Queries.GetById;
using Application.Features.BannedPrompts.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.BannedPrompts.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<BannedPrompt, CreateBannedPromptCommand>().ReverseMap();
        CreateMap<BannedPrompt, CreatedBannedPromptResponse>().ReverseMap();
        CreateMap<BannedPrompt, UpdateBannedPromptCommand>().ReverseMap();
        CreateMap<BannedPrompt, UpdatedBannedPromptResponse>().ReverseMap();
        CreateMap<BannedPrompt, DeleteBannedPromptCommand>().ReverseMap();
        CreateMap<BannedPrompt, DeletedBannedPromptResponse>().ReverseMap();
        CreateMap<BannedPrompt, GetByIdBannedPromptResponse>().ReverseMap();
        CreateMap<BannedPrompt, GetListBannedPromptListItemDto>().ReverseMap();
        CreateMap<IPaginate<BannedPrompt>, GetListResponse<GetListBannedPromptListItemDto>>().ReverseMap();
    }
}
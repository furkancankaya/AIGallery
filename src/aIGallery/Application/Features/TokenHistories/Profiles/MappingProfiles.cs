using Application.Features.TokenHistories.Commands.Create;
using Application.Features.TokenHistories.Commands.Delete;
using Application.Features.TokenHistories.Commands.Update;
using Application.Features.TokenHistories.Queries.GetById;
using Application.Features.TokenHistories.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.TokenHistories.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<TokenHistory, CreateTokenHistoryCommand>().ReverseMap();
        CreateMap<TokenHistory, CreatedTokenHistoryResponse>().ReverseMap();
        CreateMap<TokenHistory, UpdateTokenHistoryCommand>().ReverseMap();
        CreateMap<TokenHistory, UpdatedTokenHistoryResponse>().ReverseMap();
        CreateMap<TokenHistory, DeleteTokenHistoryCommand>().ReverseMap();
        CreateMap<TokenHistory, DeletedTokenHistoryResponse>().ReverseMap();
        CreateMap<TokenHistory, GetByIdTokenHistoryResponse>().ReverseMap();
        CreateMap<TokenHistory, GetListTokenHistoryListItemDto>().ReverseMap();
        CreateMap<IPaginate<TokenHistory>, GetListResponse<GetListTokenHistoryListItemDto>>().ReverseMap();
    }
}
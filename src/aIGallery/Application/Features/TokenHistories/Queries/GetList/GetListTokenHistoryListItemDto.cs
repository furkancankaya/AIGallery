using Core.Application.Dtos;

namespace Application.Features.TokenHistories.Queries.GetList;

public class GetListTokenHistoryListItemDto : IDto
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public string Price { get; set; }
    public int UserId { get; set; }
}
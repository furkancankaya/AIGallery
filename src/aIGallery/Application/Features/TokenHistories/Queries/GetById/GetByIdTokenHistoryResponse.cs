using Core.Application.Responses;

namespace Application.Features.TokenHistories.Queries.GetById;

public class GetByIdTokenHistoryResponse : IResponse
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public string Price { get; set; }
    public int UserId { get; set; }
}
using Core.Application.Responses;

namespace Application.Features.TokenHistories.Commands.Update;

public class UpdatedTokenHistoryResponse : IResponse
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public string Price { get; set; }
    public int UserId { get; set; }
}
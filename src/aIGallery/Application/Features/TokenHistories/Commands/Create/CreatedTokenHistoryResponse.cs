using Core.Application.Responses;

namespace Application.Features.TokenHistories.Commands.Create;

public class CreatedTokenHistoryResponse : IResponse
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
    public int UserId { get; set; }
}
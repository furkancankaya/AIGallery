using Core.Application.Responses;

namespace Application.Features.TokenHistories.Commands.Delete;

public class DeletedTokenHistoryResponse : IResponse
{
    public Guid Id { get; set; }
}
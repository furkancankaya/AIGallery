using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ITokenHistoryRepository : IAsyncRepository<TokenHistory, Guid>, IRepository<TokenHistory, Guid>
{
}
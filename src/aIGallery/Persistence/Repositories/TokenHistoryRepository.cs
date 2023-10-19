using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class TokenHistoryRepository : EfRepositoryBase<TokenHistory, Guid, BaseDbContext>, ITokenHistoryRepository
{
    public TokenHistoryRepository(BaseDbContext context) : base(context)
    {
    }
}
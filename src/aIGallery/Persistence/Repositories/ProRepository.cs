using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ProRepository : EfRepositoryBase<Pro, Guid, BaseDbContext>, IProRepository
{
    public ProRepository(BaseDbContext context) : base(context)
    {
    }
}
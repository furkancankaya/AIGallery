using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PreparedPromptRepository : EfRepositoryBase<PreparedPrompt, Guid, BaseDbContext>, IPreparedPromptRepository
{
    public PreparedPromptRepository(BaseDbContext context) : base(context)
    {
    }
}
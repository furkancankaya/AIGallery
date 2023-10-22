using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IPreparedPromtRepository : IAsyncRepository<PreparedPrompt, Guid>, IRepository<PreparedPrompt, Guid>
{
}
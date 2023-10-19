using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IProRepository : IAsyncRepository<Pro, Guid>, IRepository<Pro, Guid>
{
}
using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
 
public class UserTempRepository : EfRepositoryBase<UserTemp, Guid, BaseDbContext>, IUserTempRepository
{
    public UserTempRepository(BaseDbContext context)
        : base(context) { }
}

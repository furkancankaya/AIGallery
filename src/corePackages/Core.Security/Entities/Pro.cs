using Core.Persistence.Repositories;
using Core.Security.Entities;


namespace Domain.Entities
{
    public class Pro : Entity<Guid>
    {
        public int Type { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }

    }
}


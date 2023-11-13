using Core.Persistence.Repositories;
using Core.Security.Entities;


namespace Domain.Entities
{
    public class TokenHistory : Entity<Guid>
    {
        public int Amount { get; set; }
        public string Price { get; set; }
        public int UserId { get; set; } 
        public virtual User? User { get; set; }

    }
}

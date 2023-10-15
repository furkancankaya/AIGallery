using Core.Persistence.Repositories;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class SaledImage : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid ImageId { get; set; }

    public virtual User? User { get; set; }
    public virtual Image? Image { get; set; }
}

using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ArtStyle : Entity<Guid>
{
    public string Logo { get; set; }
    public string Name{ get; set; }

    public virtual ICollection<Image> Image { get; set; }
}

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
    public string Prompt{ get; set; }
    public int Sort{ get; set; }

    public virtual ICollection<Image> Image { get; set; }
}

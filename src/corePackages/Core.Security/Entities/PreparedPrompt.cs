using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class PreparedPrompt : Entity<Guid>
{
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Prompt { get; set; }
    public bool TextToImage { get; set; }
    public int Gender { get; set; }  // 0 erkek , 1 kadın , 3 belirsiz
    public int Sort { get; set; }
}

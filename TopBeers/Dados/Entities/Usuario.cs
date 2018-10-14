using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TopBeers.Dados.Entities
{
    public class Usuario : IdentityUser<int>
    {
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}

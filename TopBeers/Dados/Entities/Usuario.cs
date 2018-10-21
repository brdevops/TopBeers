using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TopBeers.Dados.Entities
{
    public class Usuario : IdentityUser<int>
    {

        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class TipoCerveja
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string DescricaoTipo { get; set; }

        public ICollection<Cerveja> Cervejas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class Cerveja
    {
        public int Id { get; set; }

        public string NomeCerveja { get; set; }

        public bool Aprovado { get; set; }

        public string DescricaoCerveja { get; set; }

        public float GrauAlcoolico { get; set; }

        public int TipoCervejaId { get; set; }
        public TipoCerveja TipoCerveja { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class Cervejaria
    {
        [Key]
        public int IdCervejaria { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        public DateTime Fundacao { get; set; }
        public ICollection<Cerveja> Cervejas { get; set; }
    }
}

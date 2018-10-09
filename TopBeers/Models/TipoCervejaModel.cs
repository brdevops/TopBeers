using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Models
{
    public class TipoCervejaModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo da Cerveja")]
        public string Tipo { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string DescricaoTipo { get; set; }

        public ICollection<CervejaModel> Cervejas { get; set; }
    }
}

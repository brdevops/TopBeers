using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Models
{
    public class CervejaModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cerveja")]
        public string NomeCerveja { get; set; }

        public bool Aprovado { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string DescricaoCerveja { get; set; }

        [Required]
        [Display(Name = "Graduação Alcoólica")]
        public float GrauAlcoolico { get; set; }

        public int CurrentTipoCervejaId { get; set; }
        public TipoCervejaModel TipoCerveja { get; set; }
    }
}

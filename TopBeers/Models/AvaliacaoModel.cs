using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }

        [Display(Name = "Avaliação")]
        public double Nota { get; set; }

        [Display(Name = "Comentários")]
        public string Comentario { get; set; }
    }
}

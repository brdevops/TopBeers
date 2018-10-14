using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public double Nota { get; set; }
        [MaxLength(255)]
        public string Comentario { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }



    }
}

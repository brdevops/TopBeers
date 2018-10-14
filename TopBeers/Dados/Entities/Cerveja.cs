using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class Cerveja
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string NomeCerveja { get; set; }
        public bool Aprovado { get; set; }
        [MaxLength(255)]
        public string DescricaoCerveja { get; set; }
        //[MaxLength(20)]
        public float GrauAlcoolico { get; set; }
        [MaxLength(50)]
        public string Foto { get; set; }
        [MaxLength(50)]
        public string Origem { get; set; }
        [MaxLength(50)]
        public string Amargor { get; set; }
        public string Aroma { get; set; }
        [MaxLength(50)]
        public string Coloracao { get; set; }
        [MaxLength(1000)]
        public string Historia { get; set; }

        public int CervejariaId { get; set; }
        public Cervejaria Cerverjaria { get; set; }

        public int TipoCervejaId { get; set; }
        public TipoCerveja TipoCerveja { get; set; }
    }
}

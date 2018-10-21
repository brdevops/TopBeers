using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Entities;

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

        public IEnumerable<TipoCervejaModel> ListaTipoCerveja { get; set; }

        public static TipoCerveja Convert(TipoCervejaModel origem)
        {
            TipoCerveja destino = new TipoCerveja();

            destino.Id = origem.Id;
            destino.Tipo = origem.Tipo;
            destino.DescricaoTipo = origem.DescricaoTipo;

            return destino;
        }

        public static IEnumerable<TipoCervejaModel> Convert(IEnumerable<TipoCerveja> origem)
        {
            var lista = new List<TipoCervejaModel>();
            foreach (var item in origem)
            {
                var destino = new TipoCervejaModel();
                destino.Id = item.Id;
                destino.Tipo = item.Tipo;
                destino.DescricaoTipo = item.DescricaoTipo;

                lista.Add(destino);
            }

            return lista;
        }
    }
}

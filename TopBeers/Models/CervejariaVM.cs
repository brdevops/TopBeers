using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Entities;

namespace TopBeers.Models
{
    public class CervejariaVM
    {
        public int IdCervejaria { get; set; }
        public string Nome { get; set; }
        public DateTime Fundacao { get; set; }
        public ICollection<CervejaModel> Cervejas { get; set; }

        public IEnumerable<CervejariaVM> ListaCervejarias { get; set; }

        public static Cervejaria Convert(CervejariaVM origem)
        {
            Cervejaria destino = new Cervejaria();

            destino.IdCervejaria = origem.IdCervejaria;
           // destino.Cervejas = origem.Cervejas;
            destino.Fundacao = origem.Fundacao;
            destino.Nome = origem.Nome;

            return destino;
        }

        public static IEnumerable<CervejariaVM> Convert(IEnumerable<Cervejaria> origem)
        {
            var lista = new List<CervejariaVM>();
            foreach (var item in origem)
            {
                var destino = new CervejariaVM();
                destino.IdCervejaria = item.IdCervejaria;
                destino.Fundacao = item.Fundacao;
                destino.Nome = item.Nome;

                lista.Add(destino);
            }

            return lista;
        }
    }
}

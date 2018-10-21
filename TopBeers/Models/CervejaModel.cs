using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Entities;

namespace TopBeers.Models
{
    public class CervejaModel
    {
        public CervejaModel()
        {
        }

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


        public string Foto { get; set; }
        public string Origem { get; set; }
        public string Amargor { get; set; }
        public string Aroma { get; set; }
        public string Coloracao { get; set; }
        public string Historia { get; set; }

        [Display(Name = "Cervejaria")]
        public int IdCervejaria { get; set; }
        [Display(Name = "Tipo da Cerveja")]
        public int IdTipoCerveja { get; set; }
        public TipoCervejaModel TipoCerveja { get; set; }

        public IEnumerable<CervejariaVM> ListaCervejaria { get; set; }
        public IEnumerable<TipoCervejaModel> ListaTipoCerveja { get; set; }

        public IEnumerable<CervejaModel> ListaCervejas { get; set; }

        public static Cerveja Convert(CervejaModel origem)
        {
            Cerveja destino = new Cerveja();

            //destino.TipoCerveja = origem.TipoCerveja;
            destino.Id = origem.Id;
            destino.TipoCervejaId = origem.IdTipoCerveja;
            destino.Aprovado = origem.Aprovado;
            destino.DescricaoCerveja = origem.DescricaoCerveja;
            destino.GrauAlcoolico = origem.GrauAlcoolico;
            destino.NomeCerveja = origem.NomeCerveja;
            destino.CervejariaId = origem.IdCervejaria;

            return destino;
        }

        public static IEnumerable<CervejaModel> ConvertList(IEnumerable<Cerveja> origem)
        {
            var lista = new List<CervejaModel>();
            foreach (var item in origem)
            {
                var destino = new CervejaModel();
                destino.Id = item.Id;
                destino.IdTipoCerveja = item.TipoCervejaId;
                destino.Aprovado = item.Aprovado;
                destino.DescricaoCerveja = item.DescricaoCerveja;
                destino.GrauAlcoolico = item.GrauAlcoolico;
                destino.NomeCerveja = item.NomeCerveja;
                destino.IdCervejaria = item.CervejariaId;

                lista.Add(destino);
            }

            return lista;
        }
    }
}

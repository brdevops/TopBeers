using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public string CaminhoFoto { get; set; }
        [Display(Name = "Foto")]
        public IFormFile ArquivoUpload { get; set; }
        public string Origem { get; set; }
        public string Amargor { get; set; }
        public string Aroma { get; set; }
        public string Coloracao { get; set; }
        public string Historia { get; set; }
        public string Busca { get; set; }

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
            destino.Historia = origem.Historia;
            destino.Amargor = origem.Amargor;
            destino.Aroma = origem.Aroma;
            destino.Coloracao = origem.Coloracao;
            destino.Foto = origem.Foto;

            return destino;
        }

        public static CervejaModel Convert(Cerveja origem)
        {
            CervejaModel destino = new CervejaModel();

            //destino.TipoCerveja = origem.TipoCerveja;
            destino.Id = origem.Id;
            destino.IdTipoCerveja = origem.TipoCervejaId;
            destino.Aprovado = origem.Aprovado;
            destino.DescricaoCerveja = origem.DescricaoCerveja;
            destino.GrauAlcoolico = origem.GrauAlcoolico;
            destino.NomeCerveja = origem.NomeCerveja;
            destino.IdCervejaria = origem.TipoCervejaId;
            destino.Historia = origem.Historia;
            destino.Amargor = origem.Amargor;
            destino.Aroma = origem.Aroma;
            destino.Coloracao = origem.Coloracao;
            destino.Foto = origem.Foto;

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
                destino.Historia = item.Historia;
                destino.Amargor = item.Amargor;
                destino.Aroma = item.Aroma;
                destino.Coloracao = item.Coloracao;
                destino.Foto = item.Foto;

                lista.Add(destino);
            }

            return lista;
        }
    }
}

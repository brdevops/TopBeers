using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Dados.Negocio;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class HomeController : Controller
    {
        //private CervejaContext db = new CervejaContext();
        private readonly IntegracaoNegocio _integracaoNegocio;

        public HomeController()
        {
            _integracaoNegocio = new IntegracaoNegocio();
        }

        public IActionResult Index()
        {
            var listaCervejas = _integracaoNegocio.CervejaNegocio.ListarTodos();

            CervejaModel model = new CervejaModel();

            model.ListaCervejas = CervejaModel.ConvertList(listaCervejas);

            return View(model);
        }

        public IActionResult Beneficios()
        {
            return View();
        }

        public IActionResult Avaliar()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Procurar()
        {
            return View();
        }



        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }
    }
}

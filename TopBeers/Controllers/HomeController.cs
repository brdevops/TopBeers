using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class HomeController : Controller
    {
        private CervejaContext db = new CervejaContext();

        public IActionResult Index()
        {
            return View();
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

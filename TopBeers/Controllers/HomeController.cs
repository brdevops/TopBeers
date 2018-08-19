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

        public IActionResult Beneficios()
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

        public IActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            string nome = objHomeModel.LerNomeUsuario();
            ViewData["Nome"] = nome;

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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Models;
using Microsoft.AspNetCore.Http;

namespace TopBeers.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ValidarLogin(UsuarioModel usuario)
        //{
        //    bool login = usuario.ValidarLogin();
        //    if (login)
        //    {
        //        HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
        //        HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        TempData["MensagemLoginInvalido"] = "Dados de login incorretos!";
        //        return RedirectToAction("Beneficios", "Home");
        //    }
        //}
    }
}
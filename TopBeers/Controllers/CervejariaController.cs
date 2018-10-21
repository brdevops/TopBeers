using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Dados.Negocio;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class CervejariaController : Controller
    {
        private readonly CervejariaNegocio _cervejariaNegocio;

        public CervejariaController()
        {
            _cervejariaNegocio = new CervejariaNegocio();
        }

        public IActionResult Index()
        {
            var listaCervejarias = _cervejariaNegocio.ListarTodos();

            CervejariaVM model = new CervejariaVM();

            model.ListaCervejarias = CervejariaVM.Convert(listaCervejarias);

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarCervejaria(CervejariaVM model)
        {
            if(model == null)
                throw new Exception("Model null");

            var cervejaria = CervejariaVM.Convert(model);

            _cervejariaNegocio.SalvarCerveja(cervejaria);

             return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExcluirCervejaria(int idCervejaria)
        {
            _cervejariaNegocio.ExcluirCervejaria(idCervejaria);

            return RedirectToAction("Index");
        }
    }
}
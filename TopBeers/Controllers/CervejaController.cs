using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Dados.Negocio;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class CervejaController : Controller
    {
        private readonly CervejaNegocio _cervejaNegocio;

        public CervejaController()
        {
            _cervejaNegocio = new CervejaNegocio();
        }
        public IActionResult Index()
        {
            var listaCervejas = _cervejaNegocio.ListarTodos();

            CervejaModel model = new CervejaModel();

            model.ListaCervejas = CervejaModel.ConvertList(listaCervejas);

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarCerveja(CervejaModel model)
        {

            if (model == null)
                throw new Exception("Model null");

            var cerveja = CervejaModel.Convert(model);

            _cervejaNegocio.SalvarCerveja(cerveja);


            return View("Index");

        }

        [HttpGet]
        public IActionResult ExcluirCerveja(int idCerveja)
        {
            _cervejaNegocio.ExcluirCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AprovarCerveja(int idCerveja)
        {
            _cervejaNegocio.AprovarCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DesaprovarCerveja(int idCerveja)
        {
            _cervejaNegocio.DesaprovarCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BuscarCerveja(string busca)
        {

             var cervejas = _cervejaNegocio.BuscarCervejas(busca);

            var model = new CervejaModel();
            model.ListaCervejas = CervejaModel.ConvertList(cervejas);

            return View("Index", model);

        }
    }
}
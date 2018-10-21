using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Dados.Negocio;
using TopBeers.Models;

namespace TopBeers.Controllers
{
    public class TipoCervejaController : Controller
    {
        private readonly TipoCervejaNegocio _tipoCervejaNegocio;

        public TipoCervejaController()
        {
            _tipoCervejaNegocio = new TipoCervejaNegocio();
        }
        public IActionResult Index()
        {
            var listaTipoCerveja = _tipoCervejaNegocio.ListarTodos();

            TipoCervejaModel model = new TipoCervejaModel();

            model.ListaTipoCerveja = TipoCervejaModel.Convert(listaTipoCerveja);

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarCerveja(TipoCervejaModel model)
        {

            if (model == null)
                throw new Exception("Model null");

            var cerveja = TipoCervejaModel.Convert(model);

            _tipoCervejaNegocio.SalvarTipo(cerveja);


            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult ExcluirCerveja(int idCerveja)
        {
            _tipoCervejaNegocio.ExcluirTipo(idCerveja);

            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopBeers.Dados.Negocio;
using TopBeers.Models;

namespace TopBeers.Controllers
{

    public class CervejaController : Controller
    {
        private readonly IntegracaoNegocio _integracaoNegocio;

        public CervejaController()
        {
            _integracaoNegocio = new IntegracaoNegocio();
        }
        public IActionResult Index()
        {
            var listaCervejas = _integracaoNegocio.CervejaNegocio.ListarTodos();
            var listaCervejarias = _integracaoNegocio.CervejariaNegocio.List();
            var listaTipoCervejas = _integracaoNegocio.TipoCervejaNegocio.ListarTodos();

            CervejaModel model = new CervejaModel();

            model.ListaCervejas = CervejaModel.ConvertList(listaCervejas);
            model.ListaCervejaria = CervejariaVM.Convert(listaCervejarias);
            model.ListaTipoCerveja = TipoCervejaModel.Convert(listaTipoCervejas);

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarCerveja(CervejaModel model)
        {

            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            if (model == null)
                throw new Exception("Model null");


            var cerveja = CervejaModel.Convert(model);
            cerveja.Foto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\cervejas", model.ArquivoUpload.FileName);

            using (var stream = new FileStream(cerveja.Foto, FileMode.Create))
            {
                model.ArquivoUpload.CopyTo(stream);
            }

            _integracaoNegocio.CervejaNegocio.SalvarCerveja(cerveja);


            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult ExcluirCerveja(int idCerveja)
        {
            _integracaoNegocio.CervejaNegocio.ExcluirCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AprovarCerveja(int idCerveja)
        {
            _integracaoNegocio.CervejaNegocio.AprovarCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DesaprovarCerveja(int idCerveja)
        {
            _integracaoNegocio.CervejaNegocio.DesaprovarCerveja(idCerveja);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BuscarCerveja(string busca)
        {

             var cervejas = _integracaoNegocio.CervejaNegocio.BuscarCervejas(busca);

            var model = new CervejaModel();
            model.ListaCervejas = CervejaModel.ConvertList(cervejas);

            return View("Index", model);

        }

        public IActionResult Avaliar(int idCerveja)
        {
            var cerveja = _integracaoNegocio.CervejaNegocio.BuscarCerveja(idCerveja);

            var model = new CervejaModel();
            model = CervejaModel.Convert(cerveja);

            return View();
        }
    }
}
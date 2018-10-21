using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Context;
using TopBeers.Dados.Entities;
using TopBeers.Models;

namespace TopBeers.Dados.Negocio
{
    public class TipoCervejaNegocio
    {
        private readonly CervejaContext _context;

        public TipoCervejaNegocio()
        {
            _context = new CervejaContext();
        }

        public void SalvarTipo(TipoCerveja tipoCerveja)
        {
            if (tipoCerveja == null)
                throw new Exception("Entitie Nulo!");

            using (var uow = new UnitOfWork())
            {
                uow.TipoCervejaRepositorio.Add(tipoCerveja);
                uow.SalvarAlteracoes();
            }
        }

        public bool Existe(TipoCerveja tipoCerveja)
        {
            if (tipoCerveja == null)
                throw new Exception("Entite nulo");

            using (var uow = new UnitOfWork())
            {
                var model = uow.TipoCervejaRepositorio.GetById(tipoCerveja.Id);
                if (model != null)
                    return true;

                return false;
            }
        }

        public void Atualizar(TipoCerveja tipoCerveja)
        {
            if (tipoCerveja == null)
                throw new Exception("DTO nulo!");

            if (tipoCerveja.Id == 0)
                throw new Exception("ID cerveja inválido!");

            using (var uow = new UnitOfWork())
            {
                uow.TipoCervejaRepositorio.Update(tipoCerveja);
                uow.SalvarAlteracoes();
            }
        }

        public List<TipoCerveja> ListarTodos()
        {
            using (var uow = new UnitOfWork())
            {
                var lista = uow.TipoCervejaRepositorio.GetAll();

                return lista.ToList();
            }
        }

        public void ExcluirTipo(int idTipoCerveja)
        {
            using (var uow = new UnitOfWork())
            {
                var cerveja = uow.TipoCervejaRepositorio.GetById(idTipoCerveja);
                if (cerveja == null)
                    throw new Exception("Cerveja não localizada");

                uow.TipoCervejaRepositorio.Remove(idTipoCerveja);
                uow.SalvarAlteracoes();
            }
        }
    }
}

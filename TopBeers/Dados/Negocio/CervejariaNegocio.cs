using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Context;
using TopBeers.Dados.Entities;
using TopBeers.Models;

namespace TopBeers.Dados.Negocio
{
    public class CervejariaNegocio
    {
        private readonly CervejaContext _context;

        public CervejariaNegocio()
        {
            _context = new CervejaContext();
        }

        public void SalvarCerveja(Cervejaria cervejaria)
        {
            if (cervejaria == null)
                throw new Exception("Entitie Nulo!");

            using (var uow = new UnitOfWork())
            {
                uow.CervejariaRepositorio.Add(cervejaria);
                uow.SalvarAlteracoes();
            }
        }

        public bool Existe(Cervejaria cervejaria)
        {
            if (cervejaria == null)
                throw new Exception("Entite nulo");

            using (var uow = new UnitOfWork())
            {
                var model = uow.CervejariaRepositorio.GetById(cervejaria.IdCervejaria);
                if (model != null)
                    return true;

                return false;
            }
        }

        public Cervejaria GetById(int? idCervejaria)
        {
            if(idCervejaria == null)
                throw new Exception("Entite nulo");

            var cervejaria = new Cervejaria();
            using (var uow = new UnitOfWork())
            {
                cervejaria = uow.CervejariaRepositorio.GetById(idCervejaria.Value);
                return cervejaria;
            }

            return cervejaria;

        }

        public void Atualizar(Cervejaria cervejaria)
        {
            if (cervejaria == null)
                throw new Exception("DTO nulo!");

            if (cervejaria.IdCervejaria == 0)
                throw new Exception("ID cerveja inválido!");

            using (var uow = new UnitOfWork())
            {
                uow.CervejariaRepositorio.Update(cervejaria);
                uow.SalvarAlteracoes();
            }
        }

        public List<Cervejaria> ListarTodos()
        {
            using (var uow = new UnitOfWork())
            {
                var lista = uow.CervejariaRepositorio.GetAll();

                return lista.ToList();
            }
        }

        public IEnumerable<Cervejaria> List()
        {
            using ( var uow = new UnitOfWork())
            {
                var lista = uow.CervejariaRepositorio.GetAll();

                return lista.ToList();
            }
        }

        public void ExcluirCervejaria(int idCervejaria)
        {
            using (var uow = new UnitOfWork())
            {
                var cerveja = uow.CervejariaRepositorio.GetById(idCervejaria);
                if (cerveja == null)
                    throw new Exception("Cervejaria não localizada");

                uow.CervejariaRepositorio.Remove(idCervejaria);
                uow.SalvarAlteracoes();
            }
        }

    }
}

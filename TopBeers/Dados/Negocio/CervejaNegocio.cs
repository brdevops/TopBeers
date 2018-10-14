using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopBeers.Dados.Context;
using TopBeers.Dados.Entities;
using TopBeers.Models;

namespace TopBeers.Dados.Negocio
{
    public class CervejaNegocio
    {
        private readonly CervejaContext _context;

        public CervejaNegocio()
        {
            _context = new CervejaContext();
        }

        public void SalvarCerveja(Cerveja cerveja)
        {
            if(cerveja == null) 
                throw new Exception("Entitie Nulo!");

            using (var uow = new UnitOfWork())
            {
                uow.CervejaRepositorio.Add(cerveja);
                uow.SalvarAlteracoes();
            }
        }

        public bool Existe(Cerveja cerveja)
        {
            if(cerveja == null)
                throw new Exception("Entite nulo");

            using (var uow = new UnitOfWork())
            {
                var model = uow.CervejaRepositorio.GetById(cerveja.Id);
                if (model != null)
                    return true;

                return false;
            }
        }

        public void Atualizar(Cerveja cerveja)
        {
            if (cerveja == null)
                throw new Exception("DTO nulo!");

            if (cerveja.Id == 0)
                throw new Exception("ID cerveja inválido!");

            using (var uow = new UnitOfWork())
            {
                uow.CervejaRepositorio.Update(cerveja);
                uow.SalvarAlteracoes();
            }
        }


        public List<Cerveja> ListarTodos()
        {
            using (var uow = new UnitOfWork())
            {
                var lista = uow.CervejaRepositorio.GetAll();

                return  lista.ToList();
            }
        }

        public  IEnumerable<Cerveja> ListAll()
        {
            var cervejas =  _context.Cerveja.ToList();

            return cervejas;
        }

        public void ExcluirCerveja(int idCerveja)
        {
            using (var uow = new UnitOfWork())
            {
                var cerveja = uow.CervejaRepositorio.GetById(idCerveja);
                if (cerveja == null)
                    throw new Exception("Cerveja não localizada");

                uow.CervejaRepositorio.Remove(idCerveja);
                uow.SalvarAlteracoes();
            }
        }

        public void AprovarCerveja(int idCerveja)
        {
            using (var uow = new UnitOfWork())
            {
                var cerveja = uow.CervejaRepositorio.GetById(idCerveja);
                if (cerveja == null)
                    throw new Exception("Cerveja não localizada");

                cerveja.Aprovado = true;
                uow.CervejaRepositorio.Update(cerveja);
                uow.SalvarAlteracoes();
            }
        }


        public void DesaprovarCerveja(int idCerveja)
        {
            using (var uow = new UnitOfWork())
            {
                var cerveja = uow.CervejaRepositorio.GetById(idCerveja);
                if (cerveja == null)
                    throw new Exception("Cerveja não localizada");

                cerveja.Aprovado = false;
                uow.CervejaRepositorio.Update(cerveja);
                uow.SalvarAlteracoes();
            }
        }

        public IEnumerable<Cerveja> BuscarCervejas(string name)
        {
            var cervejas = _context.Cerveja.AsQueryable();
            var tipoCerveja = _context.TipoCerveja.AsQueryable();


            var result = from c in cervejas
                where c.NomeCerveja.Contains(name)
                select new Cerveja
                {
                    //TipoCerveja = c.TipoCerveja,
                    TipoCervejaId = c.TipoCervejaId,
                    DescricaoCerveja = c.DescricaoCerveja,
                    Aprovado = c.Aprovado,
                    GrauAlcoolico = c.GrauAlcoolico,
                    NomeCerveja = c.NomeCerveja,
                    Id = c.Id
                };

            if (result == null)
            {
                result = from c in cervejas
                    where c.DescricaoCerveja.Contains(name)
                    select new Cerveja
                    {
                        //TipoCerveja = c.TipoCerveja,
                        TipoCervejaId = c.TipoCervejaId,
                        DescricaoCerveja = c.DescricaoCerveja,
                        Aprovado = c.Aprovado,
                        GrauAlcoolico = c.GrauAlcoolico,
                        NomeCerveja = c.NomeCerveja,
                        Id = c.Id
                    }; ;
                
            }

            if (result == null)
            {
                result = from c in cervejas
                    where c.GrauAlcoolico.ToString().Contains(name)
                    select new Cerveja
                    {
                        //TipoCerveja = c.TipoCerveja,
                        TipoCervejaId = c.TipoCervejaId,
                        DescricaoCerveja = c.DescricaoCerveja,
                        Aprovado = c.Aprovado,
                        GrauAlcoolico = c.GrauAlcoolico,
                        NomeCerveja = c.NomeCerveja,
                        Id = c.Id
                    }; ;
            }
            if (result == null)
            {
                result = from c in cervejas
                    join t in tipoCerveja on c.TipoCervejaId equals t.Id
                    where t.Tipo.Contains(name)
                    select new Cerveja
                    {
                        //TipoCerveja = c.TipoCerveja,
                        TipoCervejaId = c.TipoCervejaId,
                        DescricaoCerveja = c.DescricaoCerveja,
                        Aprovado = c.Aprovado,
                        GrauAlcoolico = c.GrauAlcoolico,
                        NomeCerveja = c.NomeCerveja,
                        Id = c.Id
                    }; ;
            }

            return result.ToList();
        }

    }
}

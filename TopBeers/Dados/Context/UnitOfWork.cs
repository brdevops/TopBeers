using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Repositorio;
using TopBeers.Models;

namespace TopBeers.Dados.Context
{
    internal class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;


        private readonly CervejaContext _context;

        private  CervejaRepositorio _cervejaRepositorio;
       // private AlunoRepositorio _alunoRepositorio;
       // private PessoaRepositorio _pessoaRepositorio;

        public UnitOfWork()
        {
            _context = new CervejaContext();
        }

        public void SalvarAlteracoes()
        {
            _context.SaveChanges();
        }


        public CervejaRepositorio CervejaRepositorio
        {
            get
            {
                if (_cervejaRepositorio == null)
                    _cervejaRepositorio = new CervejaRepositorio(_context);
                return _cervejaRepositorio;
            }
        }

        //public PessoaRepositorio PessoaRepositorio
        //{
        //    get
        //    {
        //        if (_pessoaRepositorio == null)
        //            _pessoaRepositorio = new PessoaRepositorio(_context);
        //        return _pessoaRepositorio;
        //    }
        //}


        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

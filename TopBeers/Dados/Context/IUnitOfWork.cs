using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Context
{
    internal interface IUnitOfWork : IDisposable
    {
        void SalvarAlteracoes();
    }
}

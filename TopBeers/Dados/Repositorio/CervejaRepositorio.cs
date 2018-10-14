using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Context;
using TopBeers.Dados.Entities;
using TopBeers.Models;

namespace TopBeers.Dados.Repositorio
{
    public class CervejaRepositorio : Repository<Cerveja>
    {
        public CervejaRepositorio(CervejaContext dbContext) : base(dbContext) { }
    }
}

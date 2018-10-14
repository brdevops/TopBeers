using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Context
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        // TEntity GetById(Guid id);
        //  IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
    }
}

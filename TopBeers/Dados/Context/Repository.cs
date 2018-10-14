using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopBeers.Models;

namespace TopBeers.Dados.Context
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CervejaContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(CervejaContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual TEntity GetByIdString(string matricula)
        {
            return DbSet.Find(matricula);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual void Delete(string matricula)
        {
            DbSet.Remove(DbSet.Find(matricula));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

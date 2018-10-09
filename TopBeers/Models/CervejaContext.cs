using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TopBeers.Models
{
    public class CervejaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TopBeersDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CervejaModel>()
                .HasOne<TipoCervejaModel>(s => s.TipoCerveja)
                .WithMany(g => g.Cervejas)
                .HasForeignKey(s => s.CurrentTipoCervejaId);
        }

        public DbSet<CervejaModel> Cerveja { get; set; }
        public DbSet<TipoCervejaModel> TipoCerveja { get; set; }
        public DbSet<AvaliacaoModel> Avaliacao { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}

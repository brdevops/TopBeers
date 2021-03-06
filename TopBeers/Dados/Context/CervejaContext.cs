﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TopBeers.Dados.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TopBeers.Models
{
    public class CervejaContext : IdentityDbContext<Usuario, Role, int>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}

        public CervejaContext(DbContextOptions<CervejaContext> options) : base(options)
        {

        }

        public CervejaContext()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cerveja>()
                .HasOne<TipoCerveja>(s => s.TipoCerveja)
                .WithMany(g => g.Cervejas)
                .HasForeignKey(s => s.TipoCervejaId);

            modelBuilder.Entity<Cerveja>()
                .HasOne<Cervejaria>(s => s.Cerverjaria)
                .WithMany(g => g.Cervejas)
                .HasForeignKey(s => s.CervejariaId);

            modelBuilder.Entity<Avaliacao>()
                .HasOne<Usuario>(s => s.Usuario)
                .WithMany(g => g.Avaliacoes)
                .HasForeignKey(s => s.UsuarioId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("User");

            modelBuilder.Entity<Role>().ToTable("Role");

            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaim");

            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRole");

            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin");

            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaim");

            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserToken");

            modelBuilder.Entity<Usuario>(b =>
            {
                b.Property(au => au.Email)
                    .HasColumnName("EmailAddress");
            });
        }

        public DbSet<Cerveja> Cerveja { get; set; }
        public DbSet<TipoCerveja> TipoCerveja { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        //public DbSet<UsuarioModel> Usuario { get; set; }
    }
}

using Gol.Teste.Domain.Entidades;
using Gol.Teste.Infra.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Infra.EF
{
    public class Contexto : DbContext
    {
        public Contexto()
        { }

        public Contexto(DbContextOptions<Contexto> opcoes)
            : base(opcoes)
        { }

        //public DbSet<Produto> Produtos { get; set; }
        //public DbSet<ProdutoCosif> ProdutosCosif { get; set; }
        //public DbSet<MovimentoManual> MovimentosManual { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Airplane>(new AirplaneConfiguration().Configure);
        }    
    }
}
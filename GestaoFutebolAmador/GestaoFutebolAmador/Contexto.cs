using GestaoFutebolAmador.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador
{
    public class Contexto : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Scout> Scouts { get; set; }
        public DbSet<Financeiro> Financeiros { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=GFA; User ID=sa; password=1234; language=Portuguese; Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scout>()
                .HasOne(s => s.fk_jogador)
                .WithMany(j => j.Scouts)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Scout>()
                .HasOne(s => s.fk_parametro)
                .WithMany(j => j.Scouts)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Financeiro>()
                .HasOne(s => s.fk_jogador)
                .WithMany(f => f.Financeiros)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Financeiro>()
                .HasOne(s => s.fk_conta)
                .WithMany(f => f.Financeiros)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}

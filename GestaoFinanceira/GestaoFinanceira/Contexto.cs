using GestaoFinanceira.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira
{
    public class Contexto : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=GestaoFinanceira; User ID=sa; password=1234; language=Portuguese; Trusted_Connection=True");
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseLazyLoadingProxies();
            //optionsBuilder.UseChangeTrackingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            /*modelBuilder.Entity<Lancamento>()
                .Property(s => s.id)
                .HasColumnName("AlunoId");*/
            /*modelBuilder.Entity<Lancamento>()
                .Property(s => s.dt_previsao)
                //.IsRequired(false)
                .HasColumnType("datetime");
            modelBuilder.Entity<Lancamento>()
                .Property(s => s.dt_baixa)
                //.IsRequired(false)
                .HasColumnType("datetime");
            modelBuilder.Entity<Lancamento>()
                .Property(s => s.inativo)
                //.IsRequired(false)
                .HasColumnType("datetime");*/

            //modelBuilder.Entity<Scout>()
            //    .HasOne(s => s.fk_jogador)
            //    .WithMany(j => j.Scouts)
            //    .OnDelete(DeleteBehavior.ClientCascade);

            //modelBuilder.Entity<Scout>()
            //    .HasOne(s => s.fk_parametro)
            //    .WithMany(j => j.Scouts)
            //    .OnDelete(DeleteBehavior.ClientCascade);

            //modelBuilder.Entity<Lancamento>()
            //    .HasOne(s => s.fk_jogador)
            //    .WithMany(f => f.Lancamentos)
            //    .OnDelete(DeleteBehavior.ClientCascade);

            //modelBuilder.Entity<Lancamento>()
            //    .HasOne(s => s.fk_conta)
            //    .WithMany(f => f.Lancamentos)
            //    .OnDelete(DeleteBehavior.ClientCascade);
        //}
    }
}

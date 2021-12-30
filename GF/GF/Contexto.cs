using GF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GF
{
    public class Contexto : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=GF; User ID=sa; password=1234; language=Portuguese; Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            /*modelBuilder.Entity<Lancamento>()
                .Property(s => s.id)
                .HasColumnName("AlunoId");
            modelBuilder.Entity<Lancamento>()
                .Property(s => s.dt_previsao)
                .HasColumnType("date")
                .IsRequired(false);
            modelBuilder.Entity<Lancamento>()
                .Property(s => s.dt_baixa)
                .HasColumnType("date")
                .IsRequired(false);
            modelBuilder.Entity<Lancamento>()
                .Property(s => s.inativo)
                .HasColumnType("date")
                .IsRequired(false);*/


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

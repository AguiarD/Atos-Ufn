using GestaoFinanceira.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira
{
    public class Contexto : DbContext
    {
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=GestaoFinanceira; User ID=sa; password=1234")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseLazyLoadingProxies();
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
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
        }*/
    }
}

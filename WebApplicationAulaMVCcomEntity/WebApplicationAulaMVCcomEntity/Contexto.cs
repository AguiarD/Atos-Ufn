using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAulaMVCcomEntity.Models;

namespace WebApplicationAulaMVCcomEntity
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }
        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=localhost\MSSQLSERVER01; Initial Catalog=ADONet; User ID=usuario; password=senha; language=Portuguese"
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=CodeFirstEntity; User ID=usuario; password=senha; language=Portuguese; Trusted_Connection=True");
            //optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=CodeFirstEntity; User ID=sa; password=1234; language=Portuguese; Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies(); //Linha maravilhosa e linda. kkkkk - Facultativo -- Utilizada no case 4(Delete), alternativa para o case 6(Consulta por ID)
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Criar, fazer a comunicação e criar as regras
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa) //uma pessoa
                .WithMany(p => p.Emails) //com muitos emails - 
                .OnDelete(DeleteBehavior.ClientCascade); //Quando excluir uma pessoa, seus emails serão deletados também
        }
    }
}

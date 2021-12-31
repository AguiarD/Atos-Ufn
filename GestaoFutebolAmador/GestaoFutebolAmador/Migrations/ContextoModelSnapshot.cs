﻿// <auto-generated />
using GestaoFutebolAmador;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoFutebolAmador.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestaoFutebolAmador.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescConta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObsConta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoConta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Financeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContaId")
                        .HasColumnType("int");

                    b.Property<string>("DtBaixa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DtPrevisao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JogadoresId")
                        .HasColumnType("int");

                    b.Property<string>("ObsLancamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("JogadoresId");

                    b.ToTable("Financeiros");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Inativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensalista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeJogador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObsMensalista")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jogadores");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Parametro", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DescParametro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ponto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parametros");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Scout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Assistencia")
                        .HasColumnType("int");

                    b.Property<string>("DtPartida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gol")
                        .HasColumnType("int");

                    b.Property<string>("Inativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JogadorId")
                        .HasColumnType("int");

                    b.Property<int>("ObsScout")
                        .HasColumnType("int");

                    b.Property<int>("ParametrosId")
                        .HasColumnType("int");

                    b.Property<string>("ParametrosId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Ponto")
                        .HasColumnType("int");

                    b.Property<string>("Presenca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resultado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JogadorId");

                    b.HasIndex("ParametrosId1");

                    b.ToTable("Scouts");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Financeiro", b =>
                {
                    b.HasOne("GestaoFutebolAmador.Models.Conta", "Contas")
                        .WithMany()
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoFutebolAmador.Models.Jogador", "Jogadores")
                        .WithMany()
                        .HasForeignKey("JogadoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contas");

                    b.Navigation("Jogadores");
                });

            modelBuilder.Entity("GestaoFutebolAmador.Models.Scout", b =>
                {
                    b.HasOne("GestaoFutebolAmador.Models.Jogador", "Jogadores")
                        .WithMany()
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoFutebolAmador.Models.Parametro", "Parametros")
                        .WithMany()
                        .HasForeignKey("ParametrosId1");

                    b.Navigation("Jogadores");

                    b.Navigation("Parametros");
                });
#pragma warning restore 612, 618
        }
    }
}

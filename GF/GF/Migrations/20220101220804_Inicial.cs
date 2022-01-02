using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GF.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescConta = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ObsConta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescGrupo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescTipo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    TiposId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Grupo = table.Column<int>(type: "int", nullable: false),
                    GruposId = table.Column<int>(type: "int", nullable: false),
                    Conta = table.Column<int>(type: "int", nullable: false),
                    ContasId = table.Column<int>(type: "int", nullable: false),
                    ObsLancamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DtPrevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtBaixa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Contas_ContasId",
                        column: x => x.ContasId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Grupos_GruposId",
                        column: x => x.GruposId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Tipos_TiposId",
                        column: x => x.TiposId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_ContasId",
                table: "Lancamentos",
                column: "ContasId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_GruposId",
                table: "Lancamentos",
                column: "GruposId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_TiposId",
                table: "Lancamentos",
                column: "TiposId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}

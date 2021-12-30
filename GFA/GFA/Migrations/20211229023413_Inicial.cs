using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GFA.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    obs_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_jogador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mensalista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    obs_mensalista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    desc_parametro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ponto = table.Column<int>(type: "int", nullable: false),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<float>(type: "real", nullable: false),
                    obs_lancamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_previsao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_baixa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_jogadorid = table.Column<int>(type: "int", nullable: true),
                    fk_contaid = table.Column<int>(type: "int", nullable: true),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Contas_fk_contaid",
                        column: x => x.fk_contaid,
                        principalTable: "Contas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Jogadores_fk_jogadorid",
                        column: x => x.fk_jogadorid,
                        principalTable: "Jogadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scouts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_partida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_jogadorid = table.Column<int>(type: "int", nullable: true),
                    presenca = table.Column<int>(type: "int", nullable: false),
                    fk_parametroid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ponto = table.Column<int>(type: "int", nullable: false),
                    gol = table.Column<int>(type: "int", nullable: false),
                    assistencia = table.Column<int>(type: "int", nullable: false),
                    obs_scout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scouts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Scouts_Jogadores_fk_jogadorid",
                        column: x => x.fk_jogadorid,
                        principalTable: "Jogadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scouts_Parametros_fk_parametroid",
                        column: x => x.fk_parametroid,
                        principalTable: "Parametros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_fk_contaid",
                table: "Lancamentos",
                column: "fk_contaid");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_fk_jogadorid",
                table: "Lancamentos",
                column: "fk_jogadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Scouts_fk_jogadorid",
                table: "Scouts",
                column: "fk_jogadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Scouts_fk_parametroid",
                table: "Scouts",
                column: "fk_parametroid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "Scouts");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Parametros");
        }
    }
}

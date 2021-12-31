using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoFutebolAmador.Migrations
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
                    DescConta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoConta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObsConta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeJogador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensalista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObsMensalista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescParametro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Financeiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    ObsLancamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtPrevisao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtBaixa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContaId = table.Column<int>(type: "int", nullable: false),
                    JogadoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financeiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Financeiros_Contas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financeiros_Jogadores_JogadoresId",
                        column: x => x.JogadoresId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtPartida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Presenca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    Gol = table.Column<int>(type: "int", nullable: false),
                    Assistencia = table.Column<int>(type: "int", nullable: false),
                    ObsScout = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JogadorId = table.Column<int>(type: "int", nullable: false),
                    ParametrosId = table.Column<int>(type: "int", nullable: false),
                    ParametrosId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scouts_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scouts_Parametros_ParametrosId1",
                        column: x => x.ParametrosId1,
                        principalTable: "Parametros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Financeiros_ContaId",
                table: "Financeiros",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Financeiros_JogadoresId",
                table: "Financeiros",
                column: "JogadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Scouts_JogadorId",
                table: "Scouts",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Scouts_ParametrosId1",
                table: "Scouts",
                column: "ParametrosId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Financeiros");

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

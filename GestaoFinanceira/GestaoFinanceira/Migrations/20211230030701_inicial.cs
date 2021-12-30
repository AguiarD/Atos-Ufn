using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoFinanceira.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    valor = table.Column<double>(type: "float", nullable: false),
                    grupo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    conta = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_previsao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dt_baixa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrcaLucros.Migrations
{
    public partial class AddEntidadeOrcamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaldoInicial = table.Column<float>(type: "real", nullable: false),
                    Entrada = table.Column<float>(type: "real", nullable: false),
                    Dt_Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saida = table.Column<float>(type: "real", nullable: false),
                    Dt_Saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorFinal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orcamentos");
        }
    }
}

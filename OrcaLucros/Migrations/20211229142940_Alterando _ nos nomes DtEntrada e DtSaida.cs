using Microsoft.EntityFrameworkCore.Migrations;

namespace OrcaLucros.Migrations
{
    public partial class Alterando_nosnomesDtEntradaeDtSaida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Orcamentos",
                newName: "Orcamentos",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Dt_Saida",
                schema: "dbo",
                table: "Orcamentos",
                newName: "DtSaida");

            migrationBuilder.RenameColumn(
                name: "Dt_Entrada",
                schema: "dbo",
                table: "Orcamentos",
                newName: "DtEntrada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Orcamentos",
                schema: "dbo",
                newName: "Orcamentos");

            migrationBuilder.RenameColumn(
                name: "DtSaida",
                table: "Orcamentos",
                newName: "Dt_Saida");

            migrationBuilder.RenameColumn(
                name: "DtEntrada",
                table: "Orcamentos",
                newName: "Dt_Entrada");
        }
    }
}

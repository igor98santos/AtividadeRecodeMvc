using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    public partial class barco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Voo",
                newName: "NomeDestino");

            migrationBuilder.RenameColumn(
                name: "Cartao_De_Credito",
                table: "Voo",
                newName: "CartaoDeCredito");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDestino",
                table: "Voo",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "CartaoDeCredito",
                table: "Voo",
                newName: "Cartao_De_Credito");
        }
    }
}

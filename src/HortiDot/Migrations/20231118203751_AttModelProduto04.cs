using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModelProduto04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "DataPedido",
                table: "Produtos",
                newName: "DataProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataProduto",
                table: "Produtos",
                newName: "DataPedido");

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Produtos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}

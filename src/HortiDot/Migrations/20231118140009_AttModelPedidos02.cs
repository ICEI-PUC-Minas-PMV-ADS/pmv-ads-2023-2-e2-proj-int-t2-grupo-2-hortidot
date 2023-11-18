using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModelPedidos02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Produto",
                table: "Produtos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_Produto",
                table: "Produtos",
                newName: "IX_Produtos_PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                newName: "IX_Produtos_Produto");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos",
                column: "Produto",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }
    }
}

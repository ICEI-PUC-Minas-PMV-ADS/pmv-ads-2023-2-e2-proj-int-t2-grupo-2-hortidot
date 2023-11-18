using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModelPedido04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_ListaPedidosId",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produtos_ListaProdutosId",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuários_CompradorId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CompradorId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Pedidos",
                table: "Usuários");

            migrationBuilder.DropColumn(
                name: "CompradorId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "ListaProdutosId",
                table: "PedidoProduto",
                newName: "ProdutosId");

            migrationBuilder.RenameColumn(
                name: "ListaPedidosId",
                table: "PedidoProduto",
                newName: "PedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ListaProdutosId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ProdutosId");

            migrationBuilder.AddColumn<int>(
                name: "CompradorId",
                table: "Pedidos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidosId",
                table: "PedidoProduto",
                column: "PedidosId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutosId",
                table: "PedidoProduto",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidosId",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutosId",
                table: "PedidoProduto");

            migrationBuilder.DropColumn(
                name: "CompradorId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "ProdutosId",
                table: "PedidoProduto",
                newName: "ListaProdutosId");

            migrationBuilder.RenameColumn(
                name: "PedidosId",
                table: "PedidoProduto",
                newName: "ListaPedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ProdutosId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ListaProdutosId");

            migrationBuilder.AddColumn<string>(
                name: "Pedidos",
                table: "Usuários",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompradorId",
                table: "Pedidos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CompradorId",
                table: "Pedidos",
                column: "CompradorIdID");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_ListaPedidosId",
                table: "PedidoProduto",
                column: "ListaPedidosId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produtos_ListaProdutosId",
                table: "PedidoProduto",
                column: "ListaProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_CompradorId",
                table: "Pedidos",
                column: "CompradorId",
                principalTable: "Usuários",
                principalColumn: "ID");
        }
    }
}

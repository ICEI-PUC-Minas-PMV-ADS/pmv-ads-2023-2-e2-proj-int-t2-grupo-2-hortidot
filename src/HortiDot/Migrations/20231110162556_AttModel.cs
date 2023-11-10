using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pedidos",
                table: "Usuários");

            migrationBuilder.DropColumn(
                name: "CodigoComprador",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "CodigoFornecedor",
                table: "Pedidos",
                newName: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "Produto",
                table: "Produtos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Produto",
                table: "Produtos",
                column: "Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Pedido",
                table: "Pedidos",
                column: "Pedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos",
                column: "Pedido",
                principalTable: "Usuários",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos",
                column: "Produto",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Produto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_Pedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Pedido",
                table: "Pedidos",
                newName: "CodigoFornecedor");

            migrationBuilder.AddColumn<string>(
                name: "Pedidos",
                table: "Usuários",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodigoComprador",
                table: "Pedidos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

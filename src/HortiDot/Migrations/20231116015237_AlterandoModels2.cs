using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Pedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "Pedidos",
                table: "Usuários",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "Envolvidos",
                table: "Pedidos",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListaProdutos",
                table: "Pedidos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pedidos",
                table: "Usuários");

            migrationBuilder.DropColumn(
                name: "Envolvidos",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ListaProdutos",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "Produto",
                table: "Produtos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pedido",
                table: "Pedidos",
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
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos",
                column: "Produto",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }
    }
}

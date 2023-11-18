using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModelPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "CompradorId",
                table: "Pedidos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Pedidos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Produto",
                table: "Produtos",
                column: "Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CompradorId",
                table: "Pedidos",
                column: "CompradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_FornecedorId",
                table: "Pedidos",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_CompradorId",
                table: "Pedidos",
                column: "CompradorId",
                principalTable: "Usuários",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_FornecedorId",
                table: "Pedidos",
                column: "FornecedorId",
                principalTable: "Usuários",
                principalColumn: "ID");

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
                name: "FK_Pedidos_Usuários_CompradorId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuários_FornecedorId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_Produto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Produto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CompradorId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_FornecedorId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CompradorId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Pedidos");

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
    }
}

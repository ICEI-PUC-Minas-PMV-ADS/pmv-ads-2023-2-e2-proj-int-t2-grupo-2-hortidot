using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AttModelProduto03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPedido",
                table: "Produtos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPedido",
                table: "Produtos");
        }
    }
}

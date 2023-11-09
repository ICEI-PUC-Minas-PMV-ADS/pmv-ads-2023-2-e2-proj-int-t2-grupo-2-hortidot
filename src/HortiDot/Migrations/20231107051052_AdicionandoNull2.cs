using HortiDot.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNull2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Pedidos");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataPedido = table.Column<DateTime>(type: "timestamp", nullable: false),
                    StatusPedidos = table.Column<int>(type: "integer", nullable: false),
                    ListaProdutos = table.Column<List<Produto>>(type: "text", nullable: true),
                    ValorTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    CodigoComprador = table.Column<int>(type: "integer", nullable: false),
                    CodigoFornecedor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                    name: "Compradores");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    Pedidos = table.Column<string>(type: "text", nullable: true),
                    Contatos = table.Column<string>(type: "text", nullable: true),
                    TipoDeUsuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.CreateTable(
                name: "Compradores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    contatos = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: false),
                    pedidos = table.Column<string>(type: "text", nullable: false),
                    senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compradores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    contatos = table.Column<string>(type: "text", nullable: false),
                    pedidos = table.Column<string>(type: "text", nullable: false),
                    senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.ID);
                });
        }
    }
}

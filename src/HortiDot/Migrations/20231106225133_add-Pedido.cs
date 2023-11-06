using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class addPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.AlterColumn<string>(
                name: "Pedidos",
                table: "usuarios",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Contatos",
                table: "usuarios",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresa",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoDeUsuario",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "NomeEmpresa",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "TipoDeUsuario",
                table: "usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Pedidos",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contatos",
                table: "usuarios",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioTipo",
                table: "usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

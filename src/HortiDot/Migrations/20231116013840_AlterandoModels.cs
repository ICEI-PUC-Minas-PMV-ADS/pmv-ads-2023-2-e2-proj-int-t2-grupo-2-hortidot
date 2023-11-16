using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HortiDot.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.AlterColumn<int>(
                name: "Pedido",
                table: "Pedidos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos",
                column: "Pedido",
                principalTable: "Usuários",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos");

            migrationBuilder.AlterColumn<int>(
                name: "Pedido",
                table: "Pedidos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    CompradorID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Chat_Usuários_CompradorID",
                        column: x => x.CompradorID,
                        principalTable: "Usuários",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuários_Pedido",
                table: "Pedidos",
                column: "Pedido",
                principalTable: "Usuários",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoProgramado_1.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTokenRecuperacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TokenRecuperacion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenRecuperacion",
                table: "Usuarios");
        }
    }
}

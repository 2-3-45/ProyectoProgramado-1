using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoProgramado_1.Migrations
{
    /// <inheritdoc />
    public partial class AddTeatroToObra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Obras_TeatroId",
                table: "Obras",
                column: "TeatroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Teatros_TeatroId",
                table: "Obras",
                column: "TeatroId",
                principalTable: "Teatros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Teatros_TeatroId",
                table: "Obras");

            migrationBuilder.DropIndex(
                name: "IX_Obras_TeatroId",
                table: "Obras");
        }
    }
}

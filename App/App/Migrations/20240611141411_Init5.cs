using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Titles_TitleId",
                table: "Backpacks");

            migrationBuilder.DropIndex(
                name: "IX_Backpacks_TitleId",
                table: "Backpacks");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Backpacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Backpacks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_TitleId",
                table: "Backpacks",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Titles_TitleId",
                table: "Backpacks",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PersonsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Yachts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_OwnerId",
                table: "Yachts",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yachts_People_OwnerId",
                table: "Yachts",
                column: "OwnerId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yachts_People_OwnerId",
                table: "Yachts");

            migrationBuilder.DropIndex(
                name: "IX_Yachts_OwnerId",
                table: "Yachts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Yachts");
        }
    }
}

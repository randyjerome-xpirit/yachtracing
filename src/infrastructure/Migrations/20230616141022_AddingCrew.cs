using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingCrew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "yachts");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "yachts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeYachtClubId",
                table: "yachts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "yachts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    position = table.Column<int>(type: "int", nullable: false),
                    YachtId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crew_people_PersonId",
                        column: x => x.PersonId,
                        principalTable: "people",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Crew_yachts_YachtId",
                        column: x => x.YachtId,
                        principalTable: "yachts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "YachtClub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YachtClub", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_yachts_HomeYachtClubId",
                table: "yachts",
                column: "HomeYachtClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Crew_PersonId",
                table: "Crew",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Crew_YachtId",
                table: "Crew",
                column: "YachtId");

            migrationBuilder.AddForeignKey(
                name: "FK_yachts_YachtClub_HomeYachtClubId",
                table: "yachts",
                column: "HomeYachtClubId",
                principalTable: "YachtClub",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yachts_YachtClub_HomeYachtClubId",
                table: "yachts");

            migrationBuilder.DropTable(
                name: "Crew");

            migrationBuilder.DropTable(
                name: "YachtClub");

            migrationBuilder.DropIndex(
                name: "IX_yachts_HomeYachtClubId",
                table: "yachts");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "yachts");

            migrationBuilder.DropColumn(
                name: "HomeYachtClubId",
                table: "yachts");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "yachts");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "yachts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCrewConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_people_PersonId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_yachts_YachtId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_yachts_YachtClub_HomeYachtClubId",
                table: "yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yachts",
                table: "yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                table: "people");

            migrationBuilder.RenameTable(
                name: "yachts",
                newName: "Yachts");

            migrationBuilder.RenameTable(
                name: "people",
                newName: "People");

            migrationBuilder.RenameIndex(
                name: "IX_yachts_HomeYachtClubId",
                table: "Yachts",
                newName: "IX_Yachts_HomeYachtClubId");

            migrationBuilder.AlterColumn<string>(
                name: "position",
                table: "Crew",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yachts",
                table: "Yachts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_People_PersonId",
                table: "Crew",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Yachts_YachtId",
                table: "Crew",
                column: "YachtId",
                principalTable: "Yachts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Yachts_YachtClub_HomeYachtClubId",
                table: "Yachts",
                column: "HomeYachtClubId",
                principalTable: "YachtClub",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_People_PersonId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Yachts_YachtId",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Yachts_YachtClub_HomeYachtClubId",
                table: "Yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yachts",
                table: "Yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "Yachts",
                newName: "yachts");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "people");

            migrationBuilder.RenameIndex(
                name: "IX_Yachts_HomeYachtClubId",
                table: "yachts",
                newName: "IX_yachts_HomeYachtClubId");

            migrationBuilder.AlterColumn<int>(
                name: "position",
                table: "Crew",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yachts",
                table: "yachts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                table: "people",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_people_PersonId",
                table: "Crew",
                column: "PersonId",
                principalTable: "people",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_yachts_YachtId",
                table: "Crew",
                column: "YachtId",
                principalTable: "yachts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_yachts_YachtClub_HomeYachtClubId",
                table: "yachts",
                column: "HomeYachtClubId",
                principalTable: "YachtClub",
                principalColumn: "Id");
        }
    }
}

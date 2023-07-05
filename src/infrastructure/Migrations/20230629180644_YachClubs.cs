using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class YachClubs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yachts_YachtClub_HomeYachtClubId",
                table: "Yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YachtClub",
                table: "YachtClub");

            migrationBuilder.RenameTable(
                name: "YachtClub",
                newName: "YachtClubs");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "YachtClubs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "YachtClubs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "YachtClubs",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "YachtClubs",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YachtClubs",
                table: "YachtClubs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Yachts_YachtClubs_HomeYachtClubId",
                table: "Yachts",
                column: "HomeYachtClubId",
                principalTable: "YachtClubs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yachts_YachtClubs_HomeYachtClubId",
                table: "Yachts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YachtClubs",
                table: "YachtClubs");

            migrationBuilder.RenameTable(
                name: "YachtClubs",
                newName: "YachtClub");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "YachtClub",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "YachtClub",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "YachtClub",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "YachtClub",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_YachtClub",
                table: "YachtClub",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Yachts_YachtClub_HomeYachtClubId",
                table: "Yachts",
                column: "HomeYachtClubId",
                principalTable: "YachtClub",
                principalColumn: "Id");
        }
    }
}

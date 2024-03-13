using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geosphere_api.Migrations
{
    /// <inheritdoc />
    public partial class Restructuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordinates",
                table: "Places",
                newName: "Subdivision");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maki",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Maki",
                table: "Places");

            migrationBuilder.RenameColumn(
                name: "Subdivision",
                table: "Places",
                newName: "Coordinates");
        }
    }
}

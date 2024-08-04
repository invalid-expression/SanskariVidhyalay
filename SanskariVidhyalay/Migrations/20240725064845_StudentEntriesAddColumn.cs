using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanskariVidhyalay.Migrations
{
    /// <inheritdoc />
    public partial class StudentEntriesAddColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Medium",
                table: "StudentEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Standard",
                table: "StudentEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Medium",
                table: "StudentEntries");

            migrationBuilder.DropColumn(
                name: "Standard",
                table: "StudentEntries");
        }
    }
}

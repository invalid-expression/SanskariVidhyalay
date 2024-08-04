using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanskariVidhyalay.Migrations
{
    /// <inheritdoc />
    public partial class StudentEntriesAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "StudentEntries",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "StudentEntries",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");
        }
    }
}

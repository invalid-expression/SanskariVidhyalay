using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanskariVidhyalay.Migrations
{
    /// <inheritdoc />
    public partial class StudentEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentEntries",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "Varchar(15)", nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "Varchar(15)", nullable: false),
                    DateofBirth = table.Column<string>(name: "Date of Birth", type: "Varchar(15)", nullable: false),
                    MobileNumber = table.Column<string>(name: "Mobile Number", type: "Varchar(12)", nullable: false),
                    AlternativeMobileNumber = table.Column<string>(name: "Alternative Mobile Number", type: "Varchar(15)", nullable: false),
                    Address = table.Column<string>(type: "Varchar(20)", nullable: false),
                    City = table.Column<string>(type: "Varchar(20)", nullable: false),
                    Region = table.Column<string>(type: "Varchar(15)", nullable: false),
                    PinCode = table.Column<int>(name: "Pin Code", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEntries", x => x.StudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEntries");
        }
    }
}

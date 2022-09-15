using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSys.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),

                    FirstName = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Gender = table.Column<char>(type: "nvarchar (10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar (60)", maxLength: 60, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false),
                    Program = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false),
                    Semester = table.Column<string>(type: "nvarchar (50)", maxLength: 50, nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);

                });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}

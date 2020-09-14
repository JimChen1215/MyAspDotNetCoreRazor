using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetRazorDemo.Migrations
{
    public partial class AddColumnGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Student",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Student");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetRazorDemo.Migrations
{
    public partial class RemoveColumnGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

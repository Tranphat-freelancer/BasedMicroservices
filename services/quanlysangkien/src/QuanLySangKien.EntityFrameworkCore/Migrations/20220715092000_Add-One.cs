using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLySangKien.Migrations
{
    public partial class AddOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descriptions",
                table: "IdeaManagementUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descriptions",
                table: "IdeaManagementFields",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptions",
                table: "IdeaManagementUnits");

            migrationBuilder.DropColumn(
                name: "Descriptions",
                table: "IdeaManagementFields");
        }
    }
}

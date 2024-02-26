using Microsoft.EntityFrameworkCore.Migrations;

namespace RouteCSharpEntityFramework.Migrations
{
    public partial class RemoveAddressColumnFromEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

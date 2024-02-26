using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RouteCSharpEntityFramework.Migrations
{
    public partial class AddDepartmentTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DeptName = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 2, 25, 21, 14, 16, 133, DateTimeKind.Local).AddTicks(1394)),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

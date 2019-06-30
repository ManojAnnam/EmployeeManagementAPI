using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementAPI.Repository.Migrations
{
    public partial class ColumnNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Designatiom",
                table: "EmployeesDetails",
                newName: "Designation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Designation",
                table: "EmployeesDetails",
                newName: "Designatiom");
        }
    }
}

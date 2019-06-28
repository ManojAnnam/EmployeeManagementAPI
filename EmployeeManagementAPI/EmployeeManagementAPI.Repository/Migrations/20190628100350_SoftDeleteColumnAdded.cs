using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementAPI.Repository.Migrations
{
    public partial class SoftDeleteColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeesDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeesDetails");
        }
    }
}

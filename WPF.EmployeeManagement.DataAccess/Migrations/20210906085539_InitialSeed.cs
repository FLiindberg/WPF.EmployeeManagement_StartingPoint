using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF.EmployeeManagement.DataAccess.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, 1, "johnny@gmail.com", "Rafael", "Milanes" },
                    { 2, 1, "Juan@gmail.com", "Johnny", "Cage" },
                    { 3, 2, "Anna@gmail.com", "Anna", "Lindgren" },
                    { 4, 3, "John@gmail.com", "Juanete", "Pérez" },
                    { 5, 3, "new@gmail.com", "New", "SuperNew" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

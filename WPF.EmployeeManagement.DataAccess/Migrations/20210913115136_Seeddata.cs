using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF.EmployeeManagement.DataAccess.Migrations
{
    public partial class Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Phonenumber",
                value: 112);

            migrationBuilder.InsertData(
                table: "Meeting",
                columns: new[] { "Id", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 13, 13, 51, 36, 178, DateTimeKind.Local).AddTicks(8683), new DateTime(2021, 9, 13, 13, 51, 36, 176, DateTimeKind.Local).AddTicks(2429), "Rum 1" },
                    { 2, new DateTime(2021, 9, 13, 13, 51, 36, 178, DateTimeKind.Local).AddTicks(8964), new DateTime(2021, 9, 13, 13, 51, 36, 178, DateTimeKind.Local).AddTicks(8956), "Rum 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meeting",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meeting",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Phonenumber",
                value: 0);
        }
    }
}

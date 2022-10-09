using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    public partial class addeddataannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("07f29ffd-71f7-4c4e-9334-69ec3aafbe29"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("69413b86-7bd4-4fb5-902a-dcc74d7ff8a2"));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("b869fcbb-475f-4317-8eee-26c1fcf46da9"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", null, 3, "Karlsson", "0703678909", 35000m, "311 35" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("dfb3d7b3-4493-4ff2-bb93-aa8d2782cb59"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", null, 1, "Narfgren", "0707409223", 50000m, "311 45" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b869fcbb-475f-4317-8eee-26c1fcf46da9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("dfb3d7b3-4493-4ff2-bb93-aa8d2782cb59"));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("07f29ffd-71f7-4c4e-9334-69ec3aafbe29"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", "", 3, "Karlsson", "0703678909", 35000m, "311 35" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("69413b86-7bd4-4fb5-902a-dcc74d7ff8a2"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", "", 1, "Narfgren", "0707409223", 50000m, "311 45" });
        }
    }
}

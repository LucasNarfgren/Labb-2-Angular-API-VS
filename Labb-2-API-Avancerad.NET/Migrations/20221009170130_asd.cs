using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("02acb6a7-dcaa-48e2-aa11-d9abed8e28e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("9315a085-ccec-4ff5-9443-b8bc0adfbb30"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("02acb6a7-dcaa-48e2-aa11-d9abed8e28e1"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", null, 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("9315a085-ccec-4ff5-9443-b8bc0adfbb30"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", null, 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }
    }
}

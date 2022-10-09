using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    public partial class addingFullNamePropertyToEmpoyee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a629242f-14c0-4924-a5aa-9118e6a9881a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("eaddcd07-0764-482f-a8d7-621726e9515e"));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("02acb6a7-dcaa-48e2-aa11-d9abed8e28e1"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", null, 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "FullName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("9315a085-ccec-4ff5-9443-b8bc0adfbb30"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", null, 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("02acb6a7-dcaa-48e2-aa11-d9abed8e28e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("9315a085-ccec-4ff5-9443-b8bc0adfbb30"));

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("a629242f-14c0-4924-a5aa-9118e6a9881a"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("eaddcd07-0764-482f-a8d7-621726e9515e"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }
    }
}

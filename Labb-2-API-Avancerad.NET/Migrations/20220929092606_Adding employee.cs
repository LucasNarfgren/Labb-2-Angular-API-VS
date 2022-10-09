using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    public partial class Addingemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ec3444ba-a54c-418f-8db6-dd29f3b99747"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("733223dd-d33a-4ea9-88ad-3781dc12d0c0"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("ca4a5038-89b9-4464-b131-ba49ca9f2e18"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("733223dd-d33a-4ea9-88ad-3781dc12d0c0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ca4a5038-89b9-4464-b131-ba49ca9f2e18"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("ec3444ba-a54c-418f-8db6-dd29f3b99747"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", 1, "Narfgren", "0707409223", 50000m, "311 45" });
        }
    }
}

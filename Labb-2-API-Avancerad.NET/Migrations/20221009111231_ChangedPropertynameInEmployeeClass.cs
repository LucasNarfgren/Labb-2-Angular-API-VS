using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2_API_Avancerad.NET.Migrations
{
    public partial class ChangedPropertynameInEmployeeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("733223dd-d33a-4ea9-88ad-3781dc12d0c0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ca4a5038-89b9-4464-b131-ba49ca9f2e18"));

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employees",
                newName: "Address");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("a629242f-14c0-4924-a5aa-9118e6a9881a"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("eaddcd07-0764-482f-a8d7-621726e9515e"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a629242f-14c0-4924-a5aa-9118e6a9881a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("eaddcd07-0764-482f-a8d7-621726e9515e"));

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Adress");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("733223dd-d33a-4ea9-88ad-3781dc12d0c0"), "Hertings Allé 5A", "Falkenberg", 1, "narfgren@hotmail.com", "Lucas", 1, "Narfgren", "0707409223", 50000m, "311 45" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adress", "City", "DepartmentId", "Email", "FirstName", "GenderId", "LastName", "Phone", "Salary", "ZipCode" },
                values: new object[] { new Guid("ca4a5038-89b9-4464-b131-ba49ca9f2e18"), "Hertings Gatan 10A", "Falkenberg", 2, "Karlsson@hotmail.com", "Johnny", 3, "Karlsson", "0703678909", 35000m, "311 35" });
        }
    }
}

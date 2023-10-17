using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WiredBrainCoffeeBlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentID", "FirstName", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { 4, 2, "Mary Jane", true, "Parker" },
                    { 5, 4, "Bob", false, "Poppins" },
                    { 6, 10, "J. Ava", true, "Script" },
                    { 7, 10, "C. ", true, "Sharp" },
                    { 8, 1, "C", true, "Plus Plus" },
                    { 9, 5, "Blazor", true, "Server Jr" },
                    { 10, 5, "Monty", false, "Python" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

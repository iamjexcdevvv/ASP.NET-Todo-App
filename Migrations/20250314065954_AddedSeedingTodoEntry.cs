using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingTodoEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoEntries",
                columns: new[] { "Id", "DateCreated", "Taskname" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 14, 14, 59, 52, 648, DateTimeKind.Local).AddTicks(8582), "Wash plate" },
                    { 2, new DateTime(2025, 3, 14, 14, 59, 52, 648, DateTimeKind.Local).AddTicks(9085), "Clean room" },
                    { 3, new DateTime(2025, 3, 14, 14, 59, 52, 648, DateTimeKind.Local).AddTicks(9087), "Do home work" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

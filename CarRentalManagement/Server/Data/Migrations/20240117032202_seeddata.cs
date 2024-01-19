using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "id", "CreatedBy", "Datecreated", "Dateupdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9645), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9649), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "id", "CreatedBy", "Datecreated", "Dateupdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(11), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(16), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(19), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 1, 17, 11, 22, 2, 195, DateTimeKind.Local).AddTicks(23), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "colours",
                columns: new[] { "id", "CreatedBy", "Datecreated", "Dateupdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9041), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 1, 17, 11, 22, 2, 194, DateTimeKind.Local).AddTicks(9047), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "colours",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "colours",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}

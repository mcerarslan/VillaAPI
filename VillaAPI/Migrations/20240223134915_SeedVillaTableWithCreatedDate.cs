using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 49, 14, 853, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 49, 14, 853, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 49, 14, 853, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 49, 14, 853, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 49, 14, 853, DateTimeKind.Local).AddTicks(5165));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 46, 46, 882, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 46, 46, 882, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 46, 46, 882, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 46, 46, 882, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 23, 16, 46, 46, 882, DateTimeKind.Local).AddTicks(6145));
        }
    }
}

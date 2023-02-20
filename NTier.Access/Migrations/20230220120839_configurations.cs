using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTier.Access.Migrations
{
    /// <inheritdoc />
    public partial class configurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 852, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 852, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 852, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 852, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 853, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 853, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 853, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 15, 8, 38, 853, DateTimeKind.Local).AddTicks(339));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5810));
        }
    }
}

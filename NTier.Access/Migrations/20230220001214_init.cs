using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NTier.Access.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tweets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tweets_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "IsActive", "LastName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5596), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", true, "Yılmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5607), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veli", false, "Yılmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5609), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayşe", true, "Yılmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fatma", false, "Yılmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PersonId", "Topic" },
                values: new object[,]
                {
                    { 1, "Hatay deprem felaketi", new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Deprem" },
                    { 2, "Kahramanmaraş deprem felaketi", new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Deprem" },
                    { 3, "Hatay deprem felaketi", new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5808), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Deprem" },
                    { 4, "Hatay deprem felaketi", new DateTime(2023, 2, 20, 3, 12, 14, 405, DateTimeKind.Local).AddTicks(5810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Deprem" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_PersonId",
                table: "Tweets",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tweets");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}

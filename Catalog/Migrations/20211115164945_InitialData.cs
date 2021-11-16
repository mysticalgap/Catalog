using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Name", "Year" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "A Game of Thrones", 1996 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Name", "Year" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "The Hedge Knight", 1998 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "BookId", "Surname" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "George Raymond Richard Martin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}

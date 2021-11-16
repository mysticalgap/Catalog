using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95a6d859-1356-4f88-b8ff-646751f62d86", "54795c09-6de7-4969-bed6-dbe1c07f494c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "616ae43d-4a9e-4684-b06a-7eddfcbf01e4", "b7cb3777-4191-4d37-897b-066faca5044c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "616ae43d-4a9e-4684-b06a-7eddfcbf01e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a6d859-1356-4f88-b8ff-646751f62d86");
        }
    }
}

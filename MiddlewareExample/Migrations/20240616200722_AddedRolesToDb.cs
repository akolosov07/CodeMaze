using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiddlewareExample.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72abd8b3-4209-4fe0-a4ba-f34872238e1a", "0726b198-433f-4631-b794-221d5ded45c2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f22bf25-c8b1-4b1e-b7b7-44545577f61d", "22487732-95a0-40a7-adde-3e8f7415e8db", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72abd8b3-4209-4fe0-a4ba-f34872238e1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f22bf25-c8b1-4b1e-b7b7-44545577f61d");
        }
    }
}

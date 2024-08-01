using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2df2dfeb-afba-45db-a4f7-adb5c95aaf71", "bfa928cd-d43d-43cd-bae9-0b60d14c7ce0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37e55a48-d338-47d2-b556-21b0321d59ca", "4a58705f-cb88-4537-8b4d-f9bb2698c258", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "486b3a22-516e-4343-8929-1356ff2aa5ab", "2656a956-b384-4046-b9d1-ab586554d15a", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df2dfeb-afba-45db-a4f7-adb5c95aaf71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e55a48-d338-47d2-b556-21b0321d59ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "486b3a22-516e-4343-8929-1356ff2aa5ab");
        }
    }
}

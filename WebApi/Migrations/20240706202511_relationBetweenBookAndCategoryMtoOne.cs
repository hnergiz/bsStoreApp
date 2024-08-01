using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class relationBetweenBookAndCategoryMtoOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a126bf1-74f5-434f-a97d-8e013563a34e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c4fb7e-327a-42a1-8439-698d1e7cc699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4bf6963-8e07-4b3f-9131-4af1e95e90c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c7c2460-5202-4160-b4bd-5241159294f3", "51f9adee-02bf-4fa7-adea-ab5f74267885", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af961691-ae91-41e2-a670-b04c5d906fc0", "e7c96632-2cad-4f8d-8fb8-c79e6246d41e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d548fb02-a6dc-4f6f-8220-5d013aafdb1c", "2210c880-aaea-4ee8-ab75-b834b157e6b0", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c7c2460-5202-4160-b4bd-5241159294f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af961691-ae91-41e2-a670-b04c5d906fc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d548fb02-a6dc-4f6f-8220-5d013aafdb1c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a126bf1-74f5-434f-a97d-8e013563a34e", "f194dcab-33ac-4c8c-b000-4ca308f7d2f2", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4c4fb7e-327a-42a1-8439-698d1e7cc699", "2a774ebf-9eb4-4671-921b-d93d8d1551c4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4bf6963-8e07-4b3f-9131-4af1e95e90c3", "dcf2734f-c0f8-409b-a936-c2b08b89f05b", "Admin", "ADMIN" });
        }
    }
}

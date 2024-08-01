using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "611fe45d-bdcb-4db0-8f65-d8cc3f80a5f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "971f32d4-ab92-4a73-9de4-06d579ed252b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abed39fb-fc1b-4b6f-85a4-a2281f505ad6");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fe230c1-b97f-44cd-a936-e2b8cc04bd1f", "54310032-fc79-4450-a56c-bccf134b856e", "Editor", "EDITOR" },
                    { "628cc111-1db2-434f-8112-b4f699599234", "b79f048f-b00d-45e6-af7b-000cc7c8d6d4", "Admin", "ADMIN" },
                    { "7f4fa933-20b5-4f20-90cc-d4374aee7c97", "53cde927-d256-4db3-94ef-73c27b39e97c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Mathematics" },
                    { 2, "Literature" },
                    { 3, "Economics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fe230c1-b97f-44cd-a936-e2b8cc04bd1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "628cc111-1db2-434f-8112-b4f699599234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f4fa933-20b5-4f20-90cc-d4374aee7c97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "611fe45d-bdcb-4db0-8f65-d8cc3f80a5f7", "57e6ec6e-5acb-4a78-a93c-632a614fac7f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "971f32d4-ab92-4a73-9de4-06d579ed252b", "39258912-cddb-4e42-9029-78f1a6afdba3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abed39fb-fc1b-4b6f-85a4-a2281f505ad6", "ee6c9fca-a352-4a65-b8fc-ff4b2523e388", "Editor", "EDITOR" });
        }
    }
}

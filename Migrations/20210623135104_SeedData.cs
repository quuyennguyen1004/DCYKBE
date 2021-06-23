using Microsoft.EntityFrameworkCore.Migrations;

namespace Webtt.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f50709d-9829-4613-bde1-41e25e2ccc65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fe2bd9b-f1ad-48ae-a4cc-458d48da03b9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de2e74cc-d259-49ef-a77b-582855528575", "0d48cd58-45ca-4895-bd5c-0d86f9e4f518", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8df749ca-322e-4c7e-ab18-253a5eaca7e9", "f9398822-29da-49ed-81e0-e7d3d87fcd19", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8df749ca-322e-4c7e-ab18-253a5eaca7e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de2e74cc-d259-49ef-a77b-582855528575");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f50709d-9829-4613-bde1-41e25e2ccc65", "551952b6-53f5-408c-95d2-090d55dc4b8e", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fe2bd9b-f1ad-48ae-a4cc-458d48da03b9", "d6489e38-e153-4d0d-8a73-25996d234e08", "Administrator", "ADMINISTRATOR" });
        }
    }
}

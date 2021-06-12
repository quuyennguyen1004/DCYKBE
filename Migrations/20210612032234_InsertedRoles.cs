using Microsoft.EntityFrameworkCore.Migrations;

namespace Webtt.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820923c9-fa03-4454-acf1-dae742cd2e24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec0a785-3510-4964-b665-dffe483b4b05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f02b0aa-a8e6-4b92-8901-e45c3f2b6fb1", "f21a14b4-9a20-4e7a-a8a4-b3294f906a8b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2b9d401-1b92-43ac-8b5e-abe8fe2dee2d", "3d108e73-5a61-4782-9c0f-c2669a130230", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f02b0aa-a8e6-4b92-8901-e45c3f2b6fb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2b9d401-1b92-43ac-8b5e-abe8fe2dee2d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "820923c9-fa03-4454-acf1-dae742cd2e24", "783376d6-8db3-48fd-a22e-152d2cf0046e", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cec0a785-3510-4964-b665-dffe483b4b05", "c59b60b2-66a6-4c07-bc3d-7fd0b6f8bb5c", "Administrator", "ADMINISTRATOR" });
        }
    }
}

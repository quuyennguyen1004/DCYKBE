using Microsoft.EntityFrameworkCore.Migrations;

namespace Webtt.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2f6235e7-d6a3-4396-b16a-a038aee8e0a7", "a6d310bb-6981-4c3c-8ab0-dd220f57ff14", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51a15857-d480-4af0-a3bf-03c08a2606bd", "c4b5a9df-dee0-4f6c-ae30-3afb06f19d00", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f6235e7-d6a3-4396-b16a-a038aee8e0a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51a15857-d480-4af0-a3bf-03c08a2606bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de2e74cc-d259-49ef-a77b-582855528575", "0d48cd58-45ca-4895-bd5c-0d86f9e4f518", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8df749ca-322e-4c7e-ab18-253a5eaca7e9", "f9398822-29da-49ed-81e0-e7d3d87fcd19", "Administrator", "ADMINISTRATOR" });
        }
    }
}

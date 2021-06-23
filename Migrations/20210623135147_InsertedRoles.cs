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
                keyValue: "2f6235e7-d6a3-4396-b16a-a038aee8e0a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51a15857-d480-4af0-a3bf-03c08a2606bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c7e2543-2874-419a-97a3-f35b4c69225f", "8d4319bf-0cb4-4c4e-b4e7-aaf02d6177b6", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fa6a031-ebad-4f12-845e-09004282e4be", "823b9686-c9fc-4ee6-af76-eb62a1529af9", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c7e2543-2874-419a-97a3-f35b4c69225f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa6a031-ebad-4f12-845e-09004282e4be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f6235e7-d6a3-4396-b16a-a038aee8e0a7", "a6d310bb-6981-4c3c-8ab0-dd220f57ff14", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51a15857-d480-4af0-a3bf-03c08a2606bd", "c4b5a9df-dee0-4f6c-ae30-3afb06f19d00", "Administrator", "ADMINISTRATOR" });
        }
    }
}

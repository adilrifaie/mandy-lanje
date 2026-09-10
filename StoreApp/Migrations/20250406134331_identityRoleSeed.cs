using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class identityRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0abcba21-dec9-4500-b23a-bb13195a9701", null, "Admin", "ADMIN" },
                    { "7a5058c1-be92-4a0a-bb0f-c91f980d1f81", null, "User", "USER" },
                    { "de615f29-51de-4138-9413-d15ea01a596a", null, "Editor", "EDITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0abcba21-dec9-4500-b23a-bb13195a9701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5058c1-be92-4a0a-bb0f-c91f980d1f81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de615f29-51de-4138-9413-d15ea01a596a");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UserRemoveFromComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a746bf-b406-4fbf-b883-31e6f72ca7c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6a7cfe2-0951-4a28-bc76-bc8f65597ae9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ca04fa7-67c9-4bd7-ad60-97c36b28cf07", null, "User", "USER" },
                    { "3e56aa91-3c38-4e8d-a2bd-1753b873a084", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca04fa7-67c9-4bd7-ad60-97c36b28cf07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e56aa91-3c38-4e8d-a2bd-1753b873a084");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78a746bf-b406-4fbf-b883-31e6f72ca7c4", null, "Admin", "ADMIN" },
                    { "a6a7cfe2-0951-4a28-bc76-bc8f65597ae9", null, "User", "USER" }
                });
        }
    }
}

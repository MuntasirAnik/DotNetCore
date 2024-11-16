using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UserAddedInComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1a98cac5-c721-4065-829b-676faff478f4", null, "User", "USER" },
                    { "334f2d64-b2e6-454b-8767-1ec6551e3b3d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a98cac5-c721-4065-829b-676faff478f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334f2d64-b2e6-454b-8767-1ec6551e3b3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ca04fa7-67c9-4bd7-ad60-97c36b28cf07", null, "User", "USER" },
                    { "3e56aa91-3c38-4e8d-a2bd-1753b873a084", null, "Admin", "ADMIN" }
                });
        }
    }
}

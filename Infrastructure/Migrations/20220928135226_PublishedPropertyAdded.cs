using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PublishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d2a00e0-8a4b-4e9f-bc09-227a4a5cb0d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dc0c1dd-47f7-40d3-b7ee-36c67966017c");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4939f3b-4a37-471b-a80d-4f3f6eb4de5b", "57920076-bf26-407f-85ec-3527a96ff3ad", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6dd34467-60af-4046-b4bd-660e0e5a2453", "140fbf74-9a65-4f7a-8673-c053bb3c1692", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dd34467-60af-4046-b4bd-660e0e5a2453");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4939f3b-4a37-471b-a80d-4f3f6eb4de5b");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d2a00e0-8a4b-4e9f-bc09-227a4a5cb0d4", "558c9384-d553-40df-970d-04191bf71957", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dc0c1dd-47f7-40d3-b7ee-36c67966017c", "92c21ce5-5661-4714-9efb-baf7bb71ceac", "Instructor", "INSTRUCTOR" });
        }
    }
}

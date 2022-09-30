using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CurrentLectureAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09aead02-0abb-45cf-89a8-8c34f22ef5d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cdae856-46d7-4eb0-9751-4bd5dd7883ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d2a00e0-8a4b-4e9f-bc09-227a4a5cb0d4", "558c9384-d553-40df-970d-04191bf71957", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dc0c1dd-47f7-40d3-b7ee-36c67966017c", "92c21ce5-5661-4714-9efb-baf7bb71ceac", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d2a00e0-8a4b-4e9f-bc09-227a4a5cb0d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dc0c1dd-47f7-40d3-b7ee-36c67966017c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09aead02-0abb-45cf-89a8-8c34f22ef5d9", "10ca634f-0bac-4771-98bf-b51c7ef590b2", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2cdae856-46d7-4eb0-9751-4bd5dd7883ed", "1c6428a9-0caf-4685-8a19-cb8c0e15ad0b", "Instructor", "INSTRUCTOR" });
        }
    }
}

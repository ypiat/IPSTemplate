using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class DeleteData_from_TEAuthorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2345f0f5-4620-4475-86e9-5ee6abd5a932"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "a5bde9a8-238a-4cf5-aa95-440e9d47308f");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "a4a26e3b-c824-4337-8aee-8b47526c2673");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[] { new Guid("2345f0f5-4620-4475-86e9-5ee6abd5a932"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miroslav", " Rebernik", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "4f5d0bd6-2ad6-4a57-9579-09c608ae0101");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "5bffed17-12cc-4aaf-8a5e-88e9517f1b55");
        }
    }
}

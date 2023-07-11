using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class FixData_in_TEAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("20d9a362-297c-457d-a3a1-87c6790ddf27"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c11f04c1-4f2f-4652-bf72-efc5a2b27642"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d27c0fa7-23be-495a-aa2e-dba7a0d88be9"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("dabbbe73-6176-4d55-bcb2-ce799985ac93"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "b0650582-6c94-4d12-bcd5-93d2bd3e26e8");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "c13c3aff-2ebc-4621-9759-b8f1ead0e967");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("20d9a362-297c-457d-a3a1-87c6790ddf27"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ken", " Blanchard", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c11f04c1-4f2f-4652-bf72-efc5a2b27642"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John C.", " Maxwell", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d27c0fa7-23be-495a-aa2e-dba7a0d88be9"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John C.", " Maxwell", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dabbbe73-6176-4d55-bcb2-ce799985ac93"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr.Bill", " Quain", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "d1970ff4-2f8f-4781-98c6-220a3d244e19");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "cb383e78-5e70-4f8b-a2ea-eced8c4ae5c7");
        }
    }
}

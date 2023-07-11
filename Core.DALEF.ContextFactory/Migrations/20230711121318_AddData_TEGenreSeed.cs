using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_TEGenreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"),
                columns: new[] { "Color", "Name" },
                values: new object[] { "#007dc3", "Software/IT" });

            migrationBuilder.InsertData(
                table: "TEGenre",
                columns: new[] { "Id", "Active", "Color", "DateChanged", "DateCreated", "Name", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("9147b105-9b2b-4d11-8f19-64d2a588cd44"), true, "#adb5bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strokovna monografija", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), true, "#19b698", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Osebna rast/psihologija", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), true, "#ea6153", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poslovna kultura", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "c5cba60e-7f01-4b74-802c-f0d5aa68282c");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "135486c9-b439-4559-baf5-83e49b8da2f8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("9147b105-9b2b-4d11-8f19-64d2a588cd44"));

            migrationBuilder.DeleteData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"));

            migrationBuilder.DeleteData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"));

            migrationBuilder.UpdateData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"),
                columns: new[] { "Color", "Name" },
                values: new object[] { null, "IT" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "b64bf48f-9819-4175-9eea-dcbb2f54f8c7");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "6df84d2d-805c-450e-9633-466223ad6698");
        }
    }
}

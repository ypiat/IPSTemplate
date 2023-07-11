using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEPublisherSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEPublisher",
                columns: new[] { "Id", "Active", "Address", "DateChanged", "DateCreated", "Email", "Name", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("1f855264-06ea-45d1-a83d-75ace379a617"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Penguin UK", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("920ff788-b598-4f89-aa66-beeec3c0e64e"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Prentice Hall", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Založba Tuma", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pearson Education, Limited", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "9fdc146e-48c7-42be-a5b4-391c8fcd2059");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "5d6ab3f2-3338-46e7-9e2a-a313ed1f5afa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("1f855264-06ea-45d1-a83d-75ace379a617"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("920ff788-b598-4f89-aa66-beeec3c0e64e"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "eb6413a5-7cfa-42d4-ab9a-e3142f438a94");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "94ed4f59-0cf5-44e1-8d45-fbecae10198c");
        }
    }
}

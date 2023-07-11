using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_in_TEAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("182f5aff-bdef-4c83-9951-5acb08ce766c"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lea", "Pisani", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2e3b2c42-9dc6-4149-8dcc-a8c6851f7aca"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janez", "Mayer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("31afe055-c651-4730-83a4-ee6a75f3a1a3"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Manca", "Košir", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4c8ce6ab-e80f-4681-b323-97b79ed7dafa"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ana Nuša", "Kneževič", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("549a7a20-ca4c-4563-9ff1-2474c7bd878d"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", "Praper", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6a574ece-95e2-4a40-bc52-9ed5899bb0aa"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anton", "Trstenjak", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("948d913e-1c66-4fe9-a3b7-42f02366c181"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bogomir", "Kovač", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bb9b5013-d721-4c09-a86b-eb30e51d3527"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thomas", "Erikson", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c2211dbf-f130-4f08-b39a-665f57e21dad"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janez", "Bečaj", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c30a5a61-f324-4c35-9ad6-d8fa7a104be6"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vladislav", "Rajkovič", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dd378ba2-ed55-44fc-b299-c58292b62f07"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marija", "Velikonja", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "52919d28-1750-4403-b6c6-d1d47ea73b1a");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "c4d6cca8-1cfe-4916-8a9b-c7de0235d9a5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("182f5aff-bdef-4c83-9951-5acb08ce766c"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2e3b2c42-9dc6-4149-8dcc-a8c6851f7aca"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("31afe055-c651-4730-83a4-ee6a75f3a1a3"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("4c8ce6ab-e80f-4681-b323-97b79ed7dafa"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("549a7a20-ca4c-4563-9ff1-2474c7bd878d"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6a574ece-95e2-4a40-bc52-9ed5899bb0aa"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("948d913e-1c66-4fe9-a3b7-42f02366c181"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("bb9b5013-d721-4c09-a86b-eb30e51d3527"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c2211dbf-f130-4f08-b39a-665f57e21dad"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c30a5a61-f324-4c35-9ad6-d8fa7a104be6"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("dd378ba2-ed55-44fc-b299-c58292b62f07"));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class FixData_TEGenreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"),
                column: "Name",
                value: " Osebna rast/Psihologija");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "06e85bbf-db8e-4ef0-9dfe-eda0e9cc1735");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "f3cd10b3-8ecb-44a3-956f-24b78501bab4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"),
                column: "Name",
                value: " Osebna rast/psihologija");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "0590d4a0-3039-4337-9bee-18bc0e00e9cb");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "d974362e-0a85-4ba2-a150-b5250294265b");
        }
    }
}

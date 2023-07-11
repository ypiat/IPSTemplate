using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class FixData_TEBookSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"),
                column: "GenreID",
                value: new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"),
                column: "GenreID",
                value: new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "910f8ff8-30e8-4c5d-81b3-e9d3980c22be");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "f74784fd-7bc2-4037-9535-74b275fcecc0");
        }
    }
}

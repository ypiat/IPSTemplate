using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_Description_To_TEBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TEBook",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "ba2a0e71-5e99-4914-9c7d-d53d0055036a");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "329da26b-fbcc-4ca2-87a1-af99a386b2c0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TEBook");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "0de23001-7ab1-4a17-a5cc-7d8bae3c84aa");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "747eb97f-eb5d-45cf-91e7-d0edca91220e");
        }
    }
}

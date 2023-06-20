using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_Location_To_TEBookCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "TEBookCopy",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookIndex",
                table: "TEBook",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "da90050b-a54f-4dc0-9af0-e54790ec5d2f");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "94ae7554-464f-4579-9092-142d74e425ee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "TEBookCopy");

            migrationBuilder.AlterColumn<int>(
                name: "BookIndex",
                table: "TEBook",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}

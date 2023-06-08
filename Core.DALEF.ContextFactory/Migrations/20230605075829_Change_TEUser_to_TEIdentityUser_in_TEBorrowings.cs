using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Change_TEUser_to_TEIdentityUser_in_TEBorrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBorrowings_TEUser_UserID",
                table: "TEBorrowings");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "62f16681-256e-40ab-9fb5-cbb02c6774f5");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "1ea2aca2-99c2-4b12-b8c8-99cee75feb17");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBorrowings_User_UserID",
                table: "TEBorrowings",
                column: "UserID",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBorrowings_User_UserID",
                table: "TEBorrowings");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "bb7187bf-e795-491f-8dfd-b80d36f81e6c");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "69ac3d54-ee59-4fa0-ba46-6cab25c36d26");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBorrowings_TEUser_UserID",
                table: "TEBorrowings",
                column: "UserID",
                principalTable: "TEUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Change_To_nonnullable_Guid_in_TEBookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBookAuthor_TEAuthor_AuthorID",
                table: "TEBookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_TEBookAuthor_TEBook_BookID",
                table: "TEBookAuthor");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookID",
                table: "TEBookAuthor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorID",
                table: "TEBookAuthor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TEBookAuthor_TEAuthor_AuthorID",
                table: "TEBookAuthor",
                column: "AuthorID",
                principalTable: "TEAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TEBookAuthor_TEBook_BookID",
                table: "TEBookAuthor",
                column: "BookID",
                principalTable: "TEBook",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBookAuthor_TEAuthor_AuthorID",
                table: "TEBookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_TEBookAuthor_TEBook_BookID",
                table: "TEBookAuthor");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookID",
                table: "TEBookAuthor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorID",
                table: "TEBookAuthor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBookAuthor_TEAuthor_AuthorID",
                table: "TEBookAuthor",
                column: "AuthorID",
                principalTable: "TEAuthor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBookAuthor_TEBook_BookID",
                table: "TEBookAuthor",
                column: "BookID",
                principalTable: "TEBook",
                principalColumn: "Id");
        }
    }
}

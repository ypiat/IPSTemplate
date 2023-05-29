using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_New_TEBookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBook_TEAuthor_AuthorID",
                table: "TEBook");

            migrationBuilder.DropIndex(
                name: "IX_TEBook_AuthorID",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "TEBook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AuthorID",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TEBook_AuthorID",
                table: "TEBook",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBook_TEAuthor_AuthorID",
                table: "TEBook",
                column: "AuthorID",
                principalTable: "TEAuthor",
                principalColumn: "Id");
        }
    }
}

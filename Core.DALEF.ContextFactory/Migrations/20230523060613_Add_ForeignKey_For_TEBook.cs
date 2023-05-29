using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_ForeignKey_For_TEBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "TEBook",
                newName: "PublisherID");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "TEBook",
                newName: "AuthorID");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherID",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorID",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_TEBook_AuthorID",
                table: "TEBook",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_TEBook_PublisherID",
                table: "TEBook",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBook_TEAuthor_AuthorID",
                table: "TEBook",
                column: "AuthorID",
                principalTable: "TEAuthor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBook_TEPublisher_PublisherID",
                table: "TEBook",
                column: "PublisherID",
                principalTable: "TEPublisher",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBook_TEAuthor_AuthorID",
                table: "TEBook");

            migrationBuilder.DropForeignKey(
                name: "FK_TEBook_TEPublisher_PublisherID",
                table: "TEBook");

            migrationBuilder.DropIndex(
                name: "IX_TEBook_AuthorID",
                table: "TEBook");

            migrationBuilder.DropIndex(
                name: "IX_TEBook_PublisherID",
                table: "TEBook");

            migrationBuilder.RenameColumn(
                name: "PublisherID",
                table: "TEBook",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "TEBook",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherId",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}

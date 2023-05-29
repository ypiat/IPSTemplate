using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Edit_TEBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBook_TEPublisher_PublisherID",
                table: "TEBook");

            migrationBuilder.DropIndex(
                name: "IX_TEBook_PublisherID",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "PublishedYear",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "TEBook");

            migrationBuilder.AddColumn<Guid>(
                name: "GenreID",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "TEBook",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageAmount",
                table: "TEBook",
                type: "int",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TEBook_GenreID",
                table: "TEBook",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBook_TEGenre_GenreID",
                table: "TEBook",
                column: "GenreID",
                principalTable: "TEGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEBook_TEGenre_GenreID",
                table: "TEBook");

            migrationBuilder.DropIndex(
                name: "IX_TEBook_GenreID",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "TEBook");

            migrationBuilder.DropColumn(
                name: "PageAmount",
                table: "TEBook");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "TEBook",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PublishedYear",
                table: "TEBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherID",
                table: "TEBook",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TEBook_PublisherID",
                table: "TEBook",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEBook_TEPublisher_PublisherID",
                table: "TEBook",
                column: "PublisherID",
                principalTable: "TEPublisher",
                principalColumn: "Id");
        }
    }
}

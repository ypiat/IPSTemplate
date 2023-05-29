using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Back_to_BirthYear_from_BirthDate_for_TEAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "TEAuthor");

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "TEAuthor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "TEAuthor");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "TEAuthor",
                type: "datetime2",
                nullable: true);
        }
    }
}

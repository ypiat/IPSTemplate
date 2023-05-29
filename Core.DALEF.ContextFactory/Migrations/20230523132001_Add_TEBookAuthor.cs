using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEBookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TEBookAuthor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreatedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserChangedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEBookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TEBookAuthor_TEAuthor_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "TEAuthor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEBookAuthor_TEBook_BookID",
                        column: x => x.BookID,
                        principalTable: "TEBook",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEBookAuthor_AuthorID",
                table: "TEBookAuthor",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_TEBookAuthor_BookID",
                table: "TEBookAuthor",
                column: "BookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEBookAuthor");
        }
    }
}

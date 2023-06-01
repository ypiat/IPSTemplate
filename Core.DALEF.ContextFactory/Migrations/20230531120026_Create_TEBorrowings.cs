using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Create_TEBorrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TEBorrowings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookCopyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartBorrowing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndBorrowing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreatedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserChangedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEBorrowings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TEBorrowings_TEBookCopy_BookCopyID",
                        column: x => x.BookCopyID,
                        principalTable: "TEBookCopy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TEBorrowings_TEUser_UserID",
                        column: x => x.UserID,
                        principalTable: "TEUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEBorrowings_BookCopyID",
                table: "TEBorrowings",
                column: "BookCopyID");

            migrationBuilder.CreateIndex(
                name: "IX_TEBorrowings_UserID",
                table: "TEBorrowings",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEBorrowings");
        }
    }
}

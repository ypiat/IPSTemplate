using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEBookSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBook",
                columns: new[] { "Id", "Active", "BookIndex", "DateChanged", "DateCreated", "Description", "GenreID", "Language", "Name", "PageAmount", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"), true, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life and work are intrinsically linked. They are not separate; they are one. If we want to live an extraordinary life, we have to make our work equally extraordinary. When your work resonates with purpose, you jump out of bed every morning, excited by the possibilities the day holds for you. Everything else in your life seems to have a glow about it, and you exude much more personal shine. My aim in writing this book is to help you feel like that every day. To help you make your work work for you. To feel truly free. Reading Free! will remind you that you are fantastic and have the ability to do amazing things; show you that work is your slave, not the other way round; help you make work your ticket to an extraordinary future; and put you in the driving seat and show you a route to freedom.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Free! Love Your Work, Love Your Life", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"), true, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Even bad code can function. But if code isn&rsquo;t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn&rsquo;t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with  Clean Code: A Handbook of Agile Software Craftsmanship . Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code &ldquo;on the fly&rdquo; into a book that will instill within you the values of a software craftsman and make you a better programmer&mdash;but only if you work at it. What kind of work will you be doing? You&rsquo;ll be reading code&mdash;lots of code. And you will be challenged to think about what&rsquo;s right about that code, and what&rsquo;s wrong with it. More importantly, you will be challenged to reassess your professional values and your commitment to your craft.   Clean Code  is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code&mdash;of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and &ldquo;smells&rdquo; gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code. Readers will come away from this book understanding  How to tell the difference between good and bad code How to write good code and how to transform bad code into good code How to create good names, good functions, good objects, and good classes How to format code for maximum readability How to implement complete error handling without obscuring code logic How to unit test and practice test-driven development This book is a must for any developer, software engineer, project manager, team lead, or systems analyst with an interest in producing better code.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Clean Code: A Handbook of Agile Software Craftsmanship", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "fd6491f3-30a3-43fc-b5c6-5a2481a14f37");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "d29bc0b2-5bfb-4da2-8af0-43b06dbfec4b");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "ef2c9a2a-379b-4ff4-a92f-6d0b9eb816d4");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "4119417a-d3bd-42af-9295-0b52d2ff32f1");
        }
    }
}

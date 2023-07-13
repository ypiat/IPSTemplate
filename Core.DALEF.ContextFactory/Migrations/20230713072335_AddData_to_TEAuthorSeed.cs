using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_to_TEAuthorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("01c93bf9-ecee-41f2-aa3e-731ca4a882bd"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", " Rivera", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("03484336-c8f3-4289-8687-68fb0592f239"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, " Todd", " Sattersten", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("073e550d-3cb8-4994-83ae-28e5feeeae97"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anthony", " Robbins", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("086c4795-593b-4bc7-ab4f-706111466b4a"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silvester", " Kmetič", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0b42e1a4-2a85-45e0-8b03-77d906cb9fff"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blair", " Singer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1381097f-df25-4195-bfc0-aba0f8795212"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Metka", " Feher Pal", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("179acd1e-d638-4c2b-8881-b320e65bbe11"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anni", " Koubek", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2105ceca-fa50-4c56-bd2a-855e460846a9"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark", " Seemann", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("22c9d8a8-2c67-4032-b0e0-c252a7b19a25"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ellen", " Singer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2345f0f5-4620-4475-86e9-5ee6abd5a932"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miroslav", " Rebernik", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2751ede6-c6ea-4403-b4a3-502360aaecdf"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Martin", "Limbeck", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27acf1be-139a-4845-bb0d-f8d224e4109a"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Leon", " Repovž", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("300a8f8c-9974-4851-a01b-db3d685c520b"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sonja", " Bien Karlovšek", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3e2daf63-ddb7-428d-8151-61750c7b359d"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Boštjan", " Bezlaj", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("480a2fdf-c168-44b8-b8d3-f7affdb765af"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", " Turner", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5034a08d-af1b-49cd-b960-3372f482df72"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joachim", " de Posada", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("509d296b-dad5-41c9-a8ed-0dc7adc7c816"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bernard", " Marr", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5e950864-858a-49b7-ae02-a338d4b3739f"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Max", " Mckeown", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ac460cb6-f567-4e51-913f-5f617ea39de2"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", " Drucker", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b2143981-8f53-4c3d-9dfc-36ce00c96fd5"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tomaž", " Korelc", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b5191cbd-750d-48fb-957a-80dd49c0aa48"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nigel", " Thurlow", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c88d22ae-07a2-492c-a26d-7751ac9dfcb9"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rhonda", " Byrne", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce2a42e2-6a6b-4158-8b67-b0da9f06b3a0"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", " C.Ehrhardt", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d424aac9-26df-44af-bbe9-7dfdab7ef8f4"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark J.", " Price", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d59fa0a7-6d68-401f-86f1-cd8d3824776d"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles F.", " Haanel", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d5d9580d-7306-4bf1-a6fe-0c9fa4c1d6f3"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miroslav", " Rebernik", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e88fee8e-9e43-46ae-aba8-5e2990fd6e95"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hank", " Haney", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb076567-9f47-41d6-b787-2e1a6466eff1"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jack", " Covert", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ebb5029f-906a-4c1e-8673-b88ba9b7eac8"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eugene F.", "Brigham", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f96738b8-2587-41d5-a0fc-a0cdbf594394"), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Werner", " Katzengruber", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "4f5d0bd6-2ad6-4a57-9579-09c608ae0101");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "5bffed17-12cc-4aaf-8a5e-88e9517f1b55");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("01c93bf9-ecee-41f2-aa3e-731ca4a882bd"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("03484336-c8f3-4289-8687-68fb0592f239"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("073e550d-3cb8-4994-83ae-28e5feeeae97"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("086c4795-593b-4bc7-ab4f-706111466b4a"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("0b42e1a4-2a85-45e0-8b03-77d906cb9fff"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1381097f-df25-4195-bfc0-aba0f8795212"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("179acd1e-d638-4c2b-8881-b320e65bbe11"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2105ceca-fa50-4c56-bd2a-855e460846a9"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("22c9d8a8-2c67-4032-b0e0-c252a7b19a25"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2345f0f5-4620-4475-86e9-5ee6abd5a932"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2751ede6-c6ea-4403-b4a3-502360aaecdf"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("27acf1be-139a-4845-bb0d-f8d224e4109a"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("300a8f8c-9974-4851-a01b-db3d685c520b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("3e2daf63-ddb7-428d-8151-61750c7b359d"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("480a2fdf-c168-44b8-b8d3-f7affdb765af"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5034a08d-af1b-49cd-b960-3372f482df72"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("509d296b-dad5-41c9-a8ed-0dc7adc7c816"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5e950864-858a-49b7-ae02-a338d4b3739f"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ac460cb6-f567-4e51-913f-5f617ea39de2"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b2143981-8f53-4c3d-9dfc-36ce00c96fd5"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b5191cbd-750d-48fb-957a-80dd49c0aa48"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c88d22ae-07a2-492c-a26d-7751ac9dfcb9"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ce2a42e2-6a6b-4158-8b67-b0da9f06b3a0"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d424aac9-26df-44af-bbe9-7dfdab7ef8f4"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d59fa0a7-6d68-401f-86f1-cd8d3824776d"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d5d9580d-7306-4bf1-a6fe-0c9fa4c1d6f3"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e88fee8e-9e43-46ae-aba8-5e2990fd6e95"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("eb076567-9f47-41d6-b787-2e1a6466eff1"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ebb5029f-906a-4c1e-8673-b88ba9b7eac8"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f96738b8-2587-41d5-a0fc-a0cdbf594394"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "6975b340-ec2c-483c-a750-a60ea6df1884");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "a34ccfec-956b-43f4-aa0f-37a26f211028");
        }
    }
}

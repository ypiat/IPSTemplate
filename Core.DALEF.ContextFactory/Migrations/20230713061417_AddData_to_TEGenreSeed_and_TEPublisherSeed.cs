using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_to_TEGenreSeed_and_TEPublisherSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEGenre",
                columns: new[] { "Id", "Active", "Color", "DateChanged", "DateCreated", "Name", "UserChangedID", "UserCreatedID" },
                values: new object[] { new Guid("dad56ba5-640c-4ec1-accb-35463c824b12"), true, "#f16e3f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biography/Experience", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "TEPublisher",
                columns: new[] { "Id", "Active", "Address", "DateChanged", "DateCreated", "Email", "Name", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("052833ef-ce44-4097-941a-302d21a3e3bb"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bedenik Media d.o.o ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orbis ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0dc2f9fc-33ca-4bb4-a700-a84333ffdafd"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lifetrek ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lisac &Licac", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1e9f7f17-65dd-41ff-9b2a-a1466c0a08a9"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Založba Forum Media d.o.o.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27979172-3cfe-4167-950f-b96b9f2ff157"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Packt Publishing ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("36b9ad0c-2bc9-40c7-9f83-6187fc76cbfd"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Dryden Press ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3e34d509-cfc8-4a36-b7a7-fcd38e3b1c37"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samožaložba SABB ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4119a4e3-0d37-44e3-8bf4-6674f9964c7d"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Simon &Schuster ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4371eec1-3303-40da-9b88-ee4ce07810e4"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Slovensko združevanje za kakovost in odličnost ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("47000d6e-2200-4b94-a2e7-1521be3aecef"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Creatoor ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "GV Založba, d.o.o ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("948745ee-a8b2-4493-9989-9556620e8dc7"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Časnik Finance, d.o.o ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9a9a0836-c01f-461d-a361-15b3244af1e5"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dedalus ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a62f0491-8dc0-44f9-9f04-d317a522e154"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TwentyOne Network & Amalietti d.o.o.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("afde255d-88bc-4cdc-af97-c0f57ec73b62"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Založba Amalietti, d.o.o.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4350dd3-5850-461e-b91c-43167e657312"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portfolio", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b668a744-31f0-49d7-9547-a21830398a5b"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samožaložba Metka Feher Pal ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bb474f93-4f17-456d-994c-6a89d542ff62"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Financial Times ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bcff7aec-f9b2-4cad-afae-5abfe7e57752"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "University of North Texas", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bd68b365-7014-4b4b-9feb-15cfedc63b6c"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Korotan ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amalietti & Amalietti", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cf8e0ecb-330f-4f21-9737-05c28396d3c5"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Katarina Zrinski ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f9da53f1-6b24-4d3e-b4c8-a39ec264f405"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Crown Publishing Group ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fe270392-7b99-459b-8cdf-77f0cccad02e"), true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Katzengruber ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "8385b3ba-d3d7-443f-86ec-afff6e743a76");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "a1b9105f-b113-4838-ac8e-348e76dcac6e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEGenre",
                keyColumn: "Id",
                keyValue: new Guid("dad56ba5-640c-4ec1-accb-35463c824b12"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("052833ef-ce44-4097-941a-302d21a3e3bb"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("0dc2f9fc-33ca-4bb4-a700-a84333ffdafd"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("1e9f7f17-65dd-41ff-9b2a-a1466c0a08a9"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("27979172-3cfe-4167-950f-b96b9f2ff157"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("36b9ad0c-2bc9-40c7-9f83-6187fc76cbfd"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("3e34d509-cfc8-4a36-b7a7-fcd38e3b1c37"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("4119a4e3-0d37-44e3-8bf4-6674f9964c7d"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("4371eec1-3303-40da-9b88-ee4ce07810e4"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("47000d6e-2200-4b94-a2e7-1521be3aecef"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("948745ee-a8b2-4493-9989-9556620e8dc7"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("9a9a0836-c01f-461d-a361-15b3244af1e5"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("a62f0491-8dc0-44f9-9f04-d317a522e154"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("afde255d-88bc-4cdc-af97-c0f57ec73b62"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("b4350dd3-5850-461e-b91c-43167e657312"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("b668a744-31f0-49d7-9547-a21830398a5b"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("bb474f93-4f17-456d-994c-6a89d542ff62"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("bcff7aec-f9b2-4cad-afae-5abfe7e57752"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("bd68b365-7014-4b4b-9feb-15cfedc63b6c"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("cf8e0ecb-330f-4f21-9737-05c28396d3c5"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("f9da53f1-6b24-4d3e-b4c8-a39ec264f405"));

            migrationBuilder.DeleteData(
                table: "TEPublisher",
                keyColumn: "Id",
                keyValue: new Guid("fe270392-7b99-459b-8cdf-77f0cccad02e"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "06e85bbf-db8e-4ef0-9dfe-eda0e9cc1735");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "f3cd10b3-8ecb-44a3-956f-24b78501bab4");
        }
    }
}

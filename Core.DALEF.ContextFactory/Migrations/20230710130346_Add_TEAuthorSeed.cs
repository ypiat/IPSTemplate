using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEAuthorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEUser");

            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("03f05554-2fa6-4f05-9b1f-07b1e93dc815"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Steve", " Chandler", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c828dbc-f44b-41c8-b29e-1412d0fcb749"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Benjamin", " Levy", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1d0bff2e-770e-4879-9ed5-ef86122b139d"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr. Karen ", " Pine", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1e854d42-5abc-4cb8-8612-3604f1d6338f"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maxwell", "Maltz", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("20d9a362-297c-457d-a3a1-87c6790ddf27"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ken", " Blanchard", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("22ec1668-ef8e-4c98-afcf-92c3703d278c"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Allan", " Pease", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2d2e421b-4148-4a1d-8635-ee84c339c74e"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pat", " Mesiti", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f644084-5a69-43cb-9ca5-23394463baf7"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jim", " Clemmer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("34f6ed97-96f7-44df-a576-5a0e0f22fb7b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marita", " Littauer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("377329f3-1449-44ec-96ed-963991ae4144"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr.Bill", " Quain", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3e0e45b6-f023-4f67-8a5e-73e94eb6f873"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mamie ", " McCallough", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3e1d4bd1-a459-4f34-9b44-f6df55f8d981"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lothar J.", " Seiwert", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("43110a64-ff40-4c5b-941f-ba5459e08ff6"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kare", "Anderson", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("497a44de-28f3-40ed-b3b2-0352bbf537f3"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pat", " Riley", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4bd02036-6a0f-4526-9a3d-ac479296e4c8"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chris", "Barez-Brown", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a8fa816-1db3-4281-9575-eb16a6b1b85a"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "George", " Shinn", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5bf8e384-ad9d-4382-b984-7cb6762135b7"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles C.", "Manz", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5ce3747a-ab03-49b8-8282-17c73bafd79b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Barbara", " Pease", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("64b8e52e-0365-47e2-805c-a173583b847b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Simona", " Sternad Zabukovšek", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("668b0be2-e639-409e-a37c-efd37cb9baa5"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Prof.Ben C. ", " Fletcher", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("679cff41-cbd8-4a24-b245-be846df6d70b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Burke", " Hedges", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6be06e09-e930-490a-9382-11ef9785e516"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", " Greaves", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6befae2b-6824-4da0-adc1-eb8c5a11e5ae"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carole C. ", " Carlson", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6dd90191-35f9-4bb6-9a6e-48d3875caa9f"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", "Cotton", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("718c2ca7-97ae-4059-9ed2-faa12a0f1eb8"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sheldon", " Bowles", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("72f8409a-310f-4dd4-8997-13c290f9450b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", " Sugarman", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7ea4a0e0-9b31-4ad7-b245-6fc340ddfe2e"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tjaša", " Štrukelj", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("84cb355b-9f39-4afd-8176-3db1fcbd9e26"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sam", " Beckford", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("880d61ba-fd72-42fe-a96e-83093461228c"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samo", " Bobek", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8908c397-5f49-454b-83c8-5b6d93bacab8"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dr.Marilee", " Adams", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8c52345c-b12c-476d-8457-e7a413ee0c85"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly", "Sallee", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9847031e-413b-4641-8e30-542996ec4483"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John C.", "Maxwell", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9937be0c-d710-42e1-84d4-08a51417d67b"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Todd", " Duncan", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a3b46595-20c6-456b-9a58-6137f8974ed9"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Skip ", " Ross ", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4c01ce6-a52e-4c4a-86be-726cf0798b87"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", " Fritz", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ae11c234-4cd2-4e62-a21a-1eb31d250fb3"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ann ", " McGee-Cooper", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b102a246-c9d0-4124-8dd5-63792e079d6c"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Florence", " Littauer", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b69672d6-5c2c-4f60-b0e7-12d8a763e4b4"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Travis", " Bradberry", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c11f04c1-4f2f-4652-bf72-efc5a2b27642"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John C.", " Maxwell", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c583f679-ee3f-4b8d-899c-4fc4ba9473ed"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark", " Miller", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cb20cbcd-d000-4842-95f9-7a13fdedc908"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", "Tracy", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cf9c8d7d-b7ba-4cca-996f-67c06710af99"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ken", " Blanchard", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "TEAuthor",
                columns: new[] { "Id", "Active", "BirthYear", "Country", "DateChanged", "DateCreated", "DeathYear", "FirstName", "LastName", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("d27c0fa7-23be-495a-aa2e-dba7a0d88be9"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John C.", " Maxwell", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d35d1b53-cd0e-4b42-9819-98e21fa6d2af"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert C.", "Martin", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dabbbe73-6176-4d55-bcb2-ce799985ac93"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr.Bill", " Quain", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("de0034e8-61f6-4cfb-bb00-550e18e35813"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vince", "Poscente", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ed071b6f-4d39-45f5-b656-879c8d1cd4be"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr. Dennis E.", "Hensley", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f562de09-54ff-4819-b154-bb7e753109a0"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dr. Danny", " Penman", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fd68b897-49ff-43a8-9ff8-4d2bdef78f91"), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Polona", " Tominc", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "7600a2b0-4712-4a03-97cc-6984c77960c3");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "e80d9455-967d-48ee-b1f8-42518f399aa9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("03f05554-2fa6-4f05-9b1f-07b1e93dc815"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1c828dbc-f44b-41c8-b29e-1412d0fcb749"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1d0bff2e-770e-4879-9ed5-ef86122b139d"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1e854d42-5abc-4cb8-8612-3604f1d6338f"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("20d9a362-297c-457d-a3a1-87c6790ddf27"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("22ec1668-ef8e-4c98-afcf-92c3703d278c"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2d2e421b-4148-4a1d-8635-ee84c339c74e"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2f644084-5a69-43cb-9ca5-23394463baf7"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("34f6ed97-96f7-44df-a576-5a0e0f22fb7b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("377329f3-1449-44ec-96ed-963991ae4144"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("3e0e45b6-f023-4f67-8a5e-73e94eb6f873"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("3e1d4bd1-a459-4f34-9b44-f6df55f8d981"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("43110a64-ff40-4c5b-941f-ba5459e08ff6"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("497a44de-28f3-40ed-b3b2-0352bbf537f3"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("4bd02036-6a0f-4526-9a3d-ac479296e4c8"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5a8fa816-1db3-4281-9575-eb16a6b1b85a"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5bf8e384-ad9d-4382-b984-7cb6762135b7"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5ce3747a-ab03-49b8-8282-17c73bafd79b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("64b8e52e-0365-47e2-805c-a173583b847b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("668b0be2-e639-409e-a37c-efd37cb9baa5"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("679cff41-cbd8-4a24-b245-be846df6d70b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6be06e09-e930-490a-9382-11ef9785e516"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6befae2b-6824-4da0-adc1-eb8c5a11e5ae"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6dd90191-35f9-4bb6-9a6e-48d3875caa9f"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("718c2ca7-97ae-4059-9ed2-faa12a0f1eb8"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("72f8409a-310f-4dd4-8997-13c290f9450b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("7ea4a0e0-9b31-4ad7-b245-6fc340ddfe2e"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("84cb355b-9f39-4afd-8176-3db1fcbd9e26"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("880d61ba-fd72-42fe-a96e-83093461228c"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("8908c397-5f49-454b-83c8-5b6d93bacab8"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("8c52345c-b12c-476d-8457-e7a413ee0c85"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9847031e-413b-4641-8e30-542996ec4483"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9937be0c-d710-42e1-84d4-08a51417d67b"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a3b46595-20c6-456b-9a58-6137f8974ed9"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a4c01ce6-a52e-4c4a-86be-726cf0798b87"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ae11c234-4cd2-4e62-a21a-1eb31d250fb3"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b102a246-c9d0-4124-8dd5-63792e079d6c"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b69672d6-5c2c-4f60-b0e7-12d8a763e4b4"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c11f04c1-4f2f-4652-bf72-efc5a2b27642"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c583f679-ee3f-4b8d-899c-4fc4ba9473ed"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("cb20cbcd-d000-4842-95f9-7a13fdedc908"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("cf9c8d7d-b7ba-4cca-996f-67c06710af99"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d27c0fa7-23be-495a-aa2e-dba7a0d88be9"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d35d1b53-cd0e-4b42-9819-98e21fa6d2af"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("dabbbe73-6176-4d55-bcb2-ce799985ac93"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("de0034e8-61f6-4cfb-bb00-550e18e35813"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ed071b6f-4d39-45f5-b656-879c8d1cd4be"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f562de09-54ff-4819-b154-bb7e753109a0"));

            migrationBuilder.DeleteData(
                table: "TEAuthor",
                keyColumn: "Id",
                keyValue: new Guid("fd68b897-49ff-43a8-9ff8-4d2bdef78f91"));

            migrationBuilder.CreateTable(
                name: "TEUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    UserChangedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserCreatedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEUser", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "3f920a8c-13c3-4b6c-8f46-445b5367fd77");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "992484b4-2fc4-444c-bc1b-796f08e2a00f");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEBookAuthorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBookAuthor",
                columns: new[] { "Id", "Active", "AuthorID", "BookID", "DateChanged", "DateCreated", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("02481a61-07f9-45c5-8809-c0bdab00320e"), true, new Guid("497a44de-28f3-40ed-b3b2-0352bbf537f3"), new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0cc4f451-88ff-41a2-b633-c3ffe3a4a430"), true, new Guid("668b0be2-e639-409e-a37c-efd37cb9baa5"), new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("15952e40-d30d-4d36-8c4b-14b9d1b7c05e"), true, new Guid("ae11c234-4cd2-4e62-a21a-1eb31d250fb3"), new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2449684e-5d21-4282-93e9-f5c6e958390a"), true, new Guid("d35d1b53-cd0e-4b42-9819-98e21fa6d2af"), new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("244b6ff8-5062-41e0-8960-1dcf35e798da"), true, new Guid("84cb355b-9f39-4afd-8176-3db1fcbd9e26"), new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("247572d0-d5e9-4124-9819-e600d49a4ced"), true, new Guid("377329f3-1449-44ec-96ed-963991ae4144"), new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("249cf113-a86b-471c-ae0d-ac3571fa6958"), true, new Guid("ed071b6f-4d39-45f5-b656-879c8d1cd4be"), new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("28c54b4c-bb56-4216-9025-9663de59878e"), true, new Guid("03f05554-2fa6-4f05-9b1f-07b1e93dc815"), new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("292442a8-a4bf-423f-a4bc-0db0c6589211"), true, new Guid("b69672d6-5c2c-4f60-b0e7-12d8a763e4b4"), new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("33a568c3-ca11-44e5-8355-412b81482f88"), true, new Guid("f562de09-54ff-4819-b154-bb7e753109a0"), new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("35fb169b-9a10-43ad-89de-971bb8efb221"), true, new Guid("880d61ba-fd72-42fe-a96e-83093461228c"), new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3a8644fd-ea0a-4438-b351-fa7a3f3963ac"), true, new Guid("8908c397-5f49-454b-83c8-5b6d93bacab8"), new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4041d5e3-d128-4933-a87c-fe22012f91f9"), true, new Guid("6dd90191-35f9-4bb6-9a6e-48d3875caa9f"), new Guid("96856727-b094-4e6f-941c-d15bf44d766f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("49932271-24a2-4585-bd23-4e898a2060c8"), true, new Guid("8c52345c-b12c-476d-8457-e7a413ee0c85"), new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e03e3c0-ee85-45af-abd3-a1a10d1661f1"), true, new Guid("43110a64-ff40-4c5b-941f-ba5459e08ff6"), new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a9d216f-6a91-4407-9c53-f93432095195"), true, new Guid("948d913e-1c66-4fe9-a3b7-42f02366c181"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("607fbdd3-696c-4b0b-a455-374764a4e1cd"), true, new Guid("cb20cbcd-d000-4842-95f9-7a13fdedc908"), new Guid("3678e8e4-7716-42ae-98a2-277adab4bccc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("69d747c0-8943-4dc8-ae50-219a839b65bd"), true, new Guid("cf9c8d7d-b7ba-4cca-996f-67c06710af99"), new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("716fff56-4a87-47f5-9782-f31e0c975abc"), true, new Guid("2d2e421b-4148-4a1d-8635-ee84c339c74e"), new Guid("c05bc45d-013a-497a-83f5-1ca7418f1011"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("72d278c4-5890-411d-8799-0bf8e20da219"), true, new Guid("377329f3-1449-44ec-96ed-963991ae4144"), new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("72f8eafb-76b3-4278-88bf-4ee466b94733"), true, new Guid("3e0e45b6-f023-4f67-8a5e-73e94eb6f873"), new Guid("e3553e15-459c-4585-9790-00421af356e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("734c10ec-a1f6-4b5d-b396-4a0a35dcd4ef"), true, new Guid("3e1d4bd1-a459-4f34-9b44-f6df55f8d981"), new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7543912d-6e5d-4ea4-82e1-65b8be3a1db4"), true, new Guid("c2211dbf-f130-4f08-b39a-665f57e21dad"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("75f8e734-5cf8-4701-a5dc-890e9be1e2e1"), true, new Guid("9847031e-413b-4641-8e30-542996ec4483"), new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a8d3e54-2726-4cc7-8767-beea88f65ced"), true, new Guid("5bf8e384-ad9d-4382-b984-7cb6762135b7"), new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("80aabbf4-e3a5-4ed9-a605-508aadb3f2c6"), true, new Guid("6a574ece-95e2-4a40-bc52-9ed5899bb0aa"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("823ef286-ffb7-4457-83f9-ca48b22100af"), true, new Guid("bb9b5013-d721-4c09-a86b-eb30e51d3527"), new Guid("a770ffb6-a764-446b-b9ff-6cd966c92147"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("82df1422-1585-4122-a408-5492eb3b3cfb"), true, new Guid("64b8e52e-0365-47e2-805c-a173583b847b"), new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("85f41ba7-472a-4264-bea1-e116f832242d"), true, new Guid("549a7a20-ca4c-4563-9ff1-2474c7bd878d"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9154fec5-404f-4958-916b-4ff9314eaae6"), true, new Guid("9937be0c-d710-42e1-84d4-08a51417d67b"), new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("945e0b04-0d13-49b6-830d-c3320abafc03"), true, new Guid("182f5aff-bdef-4c83-9951-5acb08ce766c"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("97f4ef0b-f9e3-4fc5-89bc-fc08b2260052"), true, new Guid("4c8ce6ab-e80f-4681-b323-97b79ed7dafa"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9caff905-8864-43c7-a54a-28af62d3d360"), true, new Guid("1d0bff2e-770e-4879-9ed5-ef86122b139d"), new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9f3ec7b9-b031-4940-b647-42ba4f5cd311"), true, new Guid("718c2ca7-97ae-4059-9ed2-faa12a0f1eb8"), new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a586d61d-e700-4a51-b28a-b106a3e1cebd"), true, new Guid("22ec1668-ef8e-4c98-afcf-92c3703d278c"), new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a929b517-fdfa-4fb7-9997-86800d24f935"), true, new Guid("679cff41-cbd8-4a24-b245-be846df6d70b"), new Guid("1ad5e814-119c-4323-a613-87e99873e67f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("acf38050-760b-4a50-87aa-7afd31b86626"), true, new Guid("72f8409a-310f-4dd4-8997-13c290f9450b"), new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("af6332cb-eb4e-4329-8f77-0ce2775ff862"), true, new Guid("fd68b897-49ff-43a8-9ff8-4d2bdef78f91"), new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b32c770a-493a-44bc-8478-6c68e701b945"), true, new Guid("6befae2b-6824-4da0-adc1-eb8c5a11e5ae"), new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b6e02c6d-9189-437d-bb26-f5e9f9c69e0a"), true, new Guid("4bd02036-6a0f-4526-9a3d-ac479296e4c8"), new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b9dad31a-2b1a-4d70-9ec7-14f7449f9c7d"), true, new Guid("9847031e-413b-4641-8e30-542996ec4483"), new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba3e9b26-6914-4028-bcec-183414569afd"), true, new Guid("1c828dbc-f44b-41c8-b29e-1412d0fcb749"), new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "TEBookAuthor",
                columns: new[] { "Id", "Active", "AuthorID", "BookID", "DateChanged", "DateCreated", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("be288432-bf6b-454a-89e3-aa57c6533726"), true, new Guid("31afe055-c651-4730-83a4-ee6a75f3a1a3"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("be9f0787-b10d-4162-853b-b0c34369e1e5"), true, new Guid("dd378ba2-ed55-44fc-b299-c58292b62f07"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c0ce42ad-dc7a-43bd-a01f-f96f3729aee4"), true, new Guid("9847031e-413b-4641-8e30-542996ec4483"), new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce885dea-1a97-401f-ba68-c5b9e9ce8ba4"), true, new Guid("6be06e09-e930-490a-9382-11ef9785e516"), new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cee18031-d948-4bc6-87ff-81806181c44f"), true, new Guid("cf9c8d7d-b7ba-4cca-996f-67c06710af99"), new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d277cc9a-6ba0-45d3-9eed-2476edbe1f7a"), true, new Guid("a4c01ce6-a52e-4c4a-86be-726cf0798b87"), new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d9e83449-e3dc-4f45-9ec2-e1d61fb1d351"), true, new Guid("34f6ed97-96f7-44df-a576-5a0e0f22fb7b"), new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("da7da3d2-05dd-4c83-88be-f32968d34c54"), true, new Guid("2e3b2c42-9dc6-4149-8dcc-a8c6851f7aca"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dd0640f1-b375-4838-9872-e27577a9c9eb"), true, new Guid("7ea4a0e0-9b31-4ad7-b245-6fc340ddfe2e"), new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e3e34dd2-e8a1-422f-bf0e-e4c85bf11f17"), true, new Guid("1e854d42-5abc-4cb8-8612-3604f1d6338f"), new Guid("aa849042-ecd7-476d-b296-610c83240ad0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5a1b46f-d984-46a2-bb23-6212bcacd1a7"), true, new Guid("5ce3747a-ab03-49b8-8282-17c73bafd79b"), new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5da9281-9e15-4607-92cc-d4150148fc33"), true, new Guid("b102a246-c9d0-4124-8dd5-63792e079d6c"), new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e7b04c2e-8eef-4e17-b2ca-d39468c6df5c"), true, new Guid("de0034e8-61f6-4cfb-bb00-550e18e35813"), new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e7befff7-dc99-4a9d-b60c-17e9696c5c7a"), true, new Guid("c583f679-ee3f-4b8d-899c-4fc4ba9473ed"), new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f2b98c3c-401f-49f1-8551-8165b8b88d43"), true, new Guid("a3b46595-20c6-456b-9a58-6137f8974ed9"), new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f51bb25b-8a9c-4df8-8619-e0f1ab774888"), true, new Guid("5a8fa816-1db3-4281-9575-eb16a6b1b85a"), new Guid("a50e2b66-93b3-4a7c-9642-52bfe9959a7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fcfe9fcb-85eb-492c-9a7b-5a6b49ecdc09"), true, new Guid("c30a5a61-f324-4c35-9ad6-d8fa7a104be6"), new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fe6a7442-6a65-43df-a108-4168d85a30c9"), true, new Guid("2f644084-5a69-43cb-9ca5-23394463baf7"), new Guid("1bdbc2a2-488a-412e-b047-82de20caab26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "b64bf48f-9819-4175-9eea-dcbb2f54f8c7");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "6df84d2d-805c-450e-9633-466223ad6698");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("02481a61-07f9-45c5-8809-c0bdab00320e"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("0cc4f451-88ff-41a2-b633-c3ffe3a4a430"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("15952e40-d30d-4d36-8c4b-14b9d1b7c05e"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2449684e-5d21-4282-93e9-f5c6e958390a"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("244b6ff8-5062-41e0-8960-1dcf35e798da"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("247572d0-d5e9-4124-9819-e600d49a4ced"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("249cf113-a86b-471c-ae0d-ac3571fa6958"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("28c54b4c-bb56-4216-9025-9663de59878e"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("292442a8-a4bf-423f-a4bc-0db0c6589211"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("33a568c3-ca11-44e5-8355-412b81482f88"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("35fb169b-9a10-43ad-89de-971bb8efb221"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("3a8644fd-ea0a-4438-b351-fa7a3f3963ac"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("4041d5e3-d128-4933-a87c-fe22012f91f9"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("49932271-24a2-4585-bd23-4e898a2060c8"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("4e03e3c0-ee85-45af-abd3-a1a10d1661f1"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5a9d216f-6a91-4407-9c53-f93432095195"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("607fbdd3-696c-4b0b-a455-374764a4e1cd"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("69d747c0-8943-4dc8-ae50-219a839b65bd"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("716fff56-4a87-47f5-9782-f31e0c975abc"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("72d278c4-5890-411d-8799-0bf8e20da219"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("72f8eafb-76b3-4278-88bf-4ee466b94733"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("734c10ec-a1f6-4b5d-b396-4a0a35dcd4ef"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("7543912d-6e5d-4ea4-82e1-65b8be3a1db4"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("75f8e734-5cf8-4701-a5dc-890e9be1e2e1"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("7a8d3e54-2726-4cc7-8767-beea88f65ced"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("80aabbf4-e3a5-4ed9-a605-508aadb3f2c6"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("823ef286-ffb7-4457-83f9-ca48b22100af"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("82df1422-1585-4122-a408-5492eb3b3cfb"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("85f41ba7-472a-4264-bea1-e116f832242d"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9154fec5-404f-4958-916b-4ff9314eaae6"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("945e0b04-0d13-49b6-830d-c3320abafc03"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("97f4ef0b-f9e3-4fc5-89bc-fc08b2260052"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9caff905-8864-43c7-a54a-28af62d3d360"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9f3ec7b9-b031-4940-b647-42ba4f5cd311"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a586d61d-e700-4a51-b28a-b106a3e1cebd"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a929b517-fdfa-4fb7-9997-86800d24f935"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("acf38050-760b-4a50-87aa-7afd31b86626"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("af6332cb-eb4e-4329-8f77-0ce2775ff862"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b32c770a-493a-44bc-8478-6c68e701b945"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b6e02c6d-9189-437d-bb26-f5e9f9c69e0a"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("b9dad31a-2b1a-4d70-9ec7-14f7449f9c7d"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ba3e9b26-6914-4028-bcec-183414569afd"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("be288432-bf6b-454a-89e3-aa57c6533726"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("be9f0787-b10d-4162-853b-b0c34369e1e5"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c0ce42ad-dc7a-43bd-a01f-f96f3729aee4"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ce885dea-1a97-401f-ba68-c5b9e9ce8ba4"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("cee18031-d948-4bc6-87ff-81806181c44f"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d277cc9a-6ba0-45d3-9eed-2476edbe1f7a"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d9e83449-e3dc-4f45-9ec2-e1d61fb1d351"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("da7da3d2-05dd-4c83-88be-f32968d34c54"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("dd0640f1-b375-4838-9872-e27577a9c9eb"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e3e34dd2-e8a1-422f-bf0e-e4c85bf11f17"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e5a1b46f-d984-46a2-bb23-6212bcacd1a7"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e5da9281-9e15-4607-92cc-d4150148fc33"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e7b04c2e-8eef-4e17-b2ca-d39468c6df5c"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e7befff7-dc99-4a9d-b60c-17e9696c5c7a"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f2b98c3c-401f-49f1-8551-8165b8b88d43"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f51bb25b-8a9c-4df8-8619-e0f1ab774888"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("fcfe9fcb-85eb-492c-9a7b-5a6b49ecdc09"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("fe6a7442-6a65-43df-a108-4168d85a30c9"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "52919d28-1750-4403-b6c6-d1d47ea73b1a");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "c4d6cca8-1cfe-4916-8a9b-c7de0235d9a5");
        }
    }
}

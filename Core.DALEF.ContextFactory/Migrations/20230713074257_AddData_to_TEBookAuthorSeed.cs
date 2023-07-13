using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_to_TEBookAuthorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBookAuthor",
                columns: new[] { "Id", "Active", "AuthorID", "BookID", "DateChanged", "DateCreated", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("07718712-daa5-40a9-a004-79aaae799ce8"), true, new Guid("5034a08d-af1b-49cd-b960-3372f482df72"), new Guid("f1d159ac-e050-47b8-8cf4-dcecd095ef91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0c1794cd-6cac-4c4a-857d-482cb304489d"), true, new Guid("ce2a42e2-6a6b-4158-8b67-b0da9f06b3a0"), new Guid("ea21bddd-6675-466c-86ee-c02f3619e456"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0fd25a7d-c27a-49cd-a07d-669f691ab969"), true, new Guid("03484336-c8f3-4289-8687-68fb0592f239"), new Guid("a15c2636-4997-4580-84eb-5c1c3ab13812"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1a96336d-fec4-466b-8f3c-1b05c5d69359"), true, new Guid("300a8f8c-9974-4851-a01b-db3d685c520b"), new Guid("7dd9600e-f823-4472-90ea-6e801cd722e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c32e0c7-5baa-494a-93f1-a36a70761398"), true, new Guid("22c9d8a8-2c67-4032-b0e0-c252a7b19a25"), new Guid("f1d159ac-e050-47b8-8cf4-dcecd095ef91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1e3a00dc-edc4-4b6d-be95-d8a3fc8ab271"), true, new Guid("0b42e1a4-2a85-45e0-8b03-77d906cb9fff"), new Guid("65f8ca71-a5a5-401e-855c-6b1ce1f58aae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1fc2a6a0-e321-4049-ade7-1d1f6da1436d"), true, new Guid("b2143981-8f53-4c3d-9dfc-36ce00c96fd5"), new Guid("dca46393-c568-4001-8e23-3a2e0492d4e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2005ed19-f6c8-44a9-b399-21c29f6cae35"), true, new Guid("3e2daf63-ddb7-428d-8151-61750c7b359d"), new Guid("aa5dafc9-7995-44b0-8f09-281c836a455c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("329f7437-07d8-44cc-ae5a-d7b6a08da149"), true, new Guid("300a8f8c-9974-4851-a01b-db3d685c520b"), new Guid("132c3c7c-29d7-4f1f-a439-2e6448fa2d05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("39e3a1aa-980e-4640-a8e2-62e4d65ecdfc"), true, new Guid("d5d9580d-7306-4bf1-a6fe-0c9fa4c1d6f3"), new Guid("285f548e-a3ff-4dea-b02b-3d423ba0061f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3c1ada41-dd81-41b8-8f58-2620ff55b235"), true, new Guid("ac460cb6-f567-4e51-913f-5f617ea39de2"), new Guid("4c72342e-50c0-499c-a3d5-b057d981c280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4de05ba8-70f6-4a85-8c14-540a1346c9a0"), true, new Guid("27acf1be-139a-4845-bb0d-f8d224e4109a"), new Guid("285f548e-a3ff-4dea-b02b-3d423ba0061f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6468f3af-88ba-4084-ad35-e2d1993c679e"), true, new Guid("509d296b-dad5-41c9-a8ed-0dc7adc7c816"), new Guid("0a4604ea-9aa8-4338-a95d-318f67d5362d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("700d0888-6711-4ea1-80c0-e16bc9196350"), true, new Guid("5e950864-858a-49b7-ae02-a338d4b3739f"), new Guid("8d61fbb6-c622-478e-9496-18f2f79d9bd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("78bab4e6-2372-4594-8f63-0f87a1530bbf"), true, new Guid("179acd1e-d638-4c2b-8881-b320e65bbe11"), new Guid("c5f70a82-af6e-4eb5-a22a-b26a0c268664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8c7641d5-13f5-446e-ac36-b90ca1ac372b"), true, new Guid("eb076567-9f47-41d6-b787-2e1a6466eff1"), new Guid("a15c2636-4997-4580-84eb-5c1c3ab13812"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8d0c0cb6-132e-40ff-8dee-0cbf50ca1dc1"), true, new Guid("480a2fdf-c168-44b8-b8d3-f7affdb765af"), new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f33f11c-faee-460c-9d61-0e3fabc585c1"), true, new Guid("1381097f-df25-4195-bfc0-aba0f8795212"), new Guid("2502db5e-3b84-4b1f-be4c-242521e06664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("97050c80-5f25-40ec-9c28-ed30b5de5513"), true, new Guid("d424aac9-26df-44af-bbe9-7dfdab7ef8f4"), new Guid("4da9369d-9d97-413d-9d79-ac7c7996325f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9a4781c9-4bea-4817-b3ab-177123f988dd"), true, new Guid("086c4795-593b-4bc7-ab4f-706111466b4a"), new Guid("f63346a8-fae7-413c-bff2-dbf4a0edf209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9df403b6-fe31-468d-a0cf-703ecca2e1bf"), true, new Guid("f96738b8-2587-41d5-a0fc-a0cdbf594394"), new Guid("f63346a8-fae7-413c-bff2-dbf4a0edf209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1cd418e-ffb7-4714-a035-8d86ec235d46"), true, new Guid("ebb5029f-906a-4c1e-8673-b88ba9b7eac8"), new Guid("ea21bddd-6675-466c-86ee-c02f3619e456"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9f3c38a-9e1f-4fc5-98a7-ce5abc1ff8a2"), true, new Guid("e88fee8e-9e43-46ae-aba8-5e2990fd6e95"), new Guid("b8f3641d-a07e-40c2-9e50-af86150a1105"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c311bd01-ad2b-4401-8f1b-f2b1cdc484e8"), true, new Guid("2105ceca-fa50-4c56-bd2a-855e460846a9"), new Guid("0bc39c50-440e-4dd6-a06f-7ee0ddbf36bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d3c5dd09-2f32-4088-8fd4-02f84b5b5923"), true, new Guid("c88d22ae-07a2-492c-a26d-7751ac9dfcb9"), new Guid("0c05a0aa-b969-4bc9-8c35-bddb6618d49d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d7a35d8b-13a8-4526-b310-c7c528e7e6ca"), true, new Guid("01c93bf9-ecee-41f2-aa3e-731ca4a882bd"), new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d868179e-4a03-440c-ac48-6dbf73891b1d"), true, new Guid("b5191cbd-750d-48fb-957a-80dd49c0aa48"), new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dcf4228c-845d-440f-8adc-863357bd6e9a"), true, new Guid("d59fa0a7-6d68-401f-86f1-cd8d3824776d"), new Guid("1a40d746-6b93-4e6c-b59d-100ad3209597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e9620422-faf3-4f51-a373-55f2064a2226"), true, new Guid("d5d9580d-7306-4bf1-a6fe-0c9fa4c1d6f3"), new Guid("c730eedf-d6b7-4b25-b89c-fc5ab9e5b9a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fd02e08f-27a7-4b35-a6e9-3c5002fd2a81"), true, new Guid("2751ede6-c6ea-4403-b4a3-502360aaecdf"), new Guid("a9830403-ee09-4cc7-a8b4-84149a961297"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ffef09fe-f1b7-4b03-a5db-41153b1a129a"), true, new Guid("073e550d-3cb8-4994-83ae-28e5feeeae97"), new Guid("c13049c8-2291-45fd-9858-22d8601c6edc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "509ce62c-2b95-4238-b1af-da0aecff2bd2");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "405606b5-7940-4a35-a2a1-12d703a6e997");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("07718712-daa5-40a9-a004-79aaae799ce8"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("0c1794cd-6cac-4c4a-857d-482cb304489d"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("0fd25a7d-c27a-49cd-a07d-669f691ab969"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1a96336d-fec4-466b-8f3c-1b05c5d69359"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1c32e0c7-5baa-494a-93f1-a36a70761398"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1e3a00dc-edc4-4b6d-be95-d8a3fc8ab271"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1fc2a6a0-e321-4049-ade7-1d1f6da1436d"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2005ed19-f6c8-44a9-b399-21c29f6cae35"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("329f7437-07d8-44cc-ae5a-d7b6a08da149"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("39e3a1aa-980e-4640-a8e2-62e4d65ecdfc"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("3c1ada41-dd81-41b8-8f58-2620ff55b235"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("4de05ba8-70f6-4a85-8c14-540a1346c9a0"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6468f3af-88ba-4084-ad35-e2d1993c679e"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("700d0888-6711-4ea1-80c0-e16bc9196350"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("78bab4e6-2372-4594-8f63-0f87a1530bbf"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("8c7641d5-13f5-446e-ac36-b90ca1ac372b"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("8d0c0cb6-132e-40ff-8dee-0cbf50ca1dc1"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("8f33f11c-faee-460c-9d61-0e3fabc585c1"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("97050c80-5f25-40ec-9c28-ed30b5de5513"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9a4781c9-4bea-4817-b3ab-177123f988dd"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9df403b6-fe31-468d-a0cf-703ecca2e1bf"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a1cd418e-ffb7-4714-a035-8d86ec235d46"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("a9f3c38a-9e1f-4fc5-98a7-ce5abc1ff8a2"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("c311bd01-ad2b-4401-8f1b-f2b1cdc484e8"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d3c5dd09-2f32-4088-8fd4-02f84b5b5923"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d7a35d8b-13a8-4526-b310-c7c528e7e6ca"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d868179e-4a03-440c-ac48-6dbf73891b1d"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("dcf4228c-845d-440f-8adc-863357bd6e9a"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("e9620422-faf3-4f51-a373-55f2064a2226"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("fd02e08f-27a7-4b35-a6e9-3c5002fd2a81"));

            migrationBuilder.DeleteData(
                table: "TEBookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("ffef09fe-f1b7-4b03-a5db-41153b1a129a"));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "a5bde9a8-238a-4cf5-aa95-440e9d47308f");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "a4a26e3b-c824-4337-8aee-8b47526c2673");
        }
    }
}

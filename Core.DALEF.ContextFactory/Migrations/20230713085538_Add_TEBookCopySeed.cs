using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class Add_TEBookCopySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBookCopy",
                columns: new[] { "Id", "Active", "BookCopyNumber", "BookID", "DateChanged", "DateCreated", "IsAvailable", "Location", "PublishedYear", "PublisherID", "QRCodeUrl", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("05cd618c-a0b7-45f3-bb2c-b5d3aa19c5c3"), true, 3801, new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("069dfe07-5e1c-44f9-8e4e-7de4cbf69939"), true, 4301, new Guid("1a40d746-6b93-4e6c-b59d-100ad3209597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("052833ef-ce44-4097-941a-302d21a3e3bb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0afe1532-d865-4b7f-9ac2-c78ebc345ded"), true, 501, new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0fc6e2b9-8de6-47e1-9062-06e8485bbda9"), true, 801, new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("17b15180-8084-4c4b-baed-e6267fcb03b7"), true, 1001, new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1a727083-e283-4bcb-bd04-7f679e37d6ea"), true, 1601, new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1999, new Guid("afde255d-88bc-4cdc-af97-c0f57ec73b62"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c814007-2090-446d-ad5a-91620eb3ace7"), true, 3501, new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2006, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1e598e8e-0f76-42b3-9e79-5a4655890043"), true, 901, new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2005, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1ef15ca3-496b-444b-bc30-d6e2984da5d9"), true, 5401, new Guid("f1d159ac-e050-47b8-8cf4-dcecd095ef91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1fae4f73-4673-4f4f-8eb9-fdd2eed487d2"), true, 3901, new Guid("a9830403-ee09-4cc7-a8b4-84149a961297"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2012, new Guid("948745ee-a8b2-4493-9989-9556620e8dc7"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("230884ea-0f24-42b7-8f85-b7abc58b5bc3"), true, 1501, new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27794355-9c6f-41d4-9bac-f0bed748ddb4"), true, 3301, new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1998, new Guid("a62f0491-8dc0-44f9-9f04-d317a522e154"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2964fd4a-5d4a-41ab-bf76-5e2d58be8919"), true, 1801, new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2020, new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2cb6c4cf-a628-458b-ac59-54c5295e91d9"), true, 5301, new Guid("c5f70a82-af6e-4eb5-a22a-b26a0c268664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2016, new Guid("4371eec1-3303-40da-9b88-ee4ce07810e4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2e6dd7bd-e633-4793-85da-55bd18212dff"), true, 6101, new Guid("7dd9600e-f823-4472-90ea-6e801cd722e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2012, new Guid("1e9f7f17-65dd-41ff-9b2a-a1466c0a08a9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2fb51db3-a1a0-486d-a8c7-ed6b0b102850"), true, 4001, new Guid("0a4604ea-9aa8-4338-a95d-318f67d5362d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2014, new Guid("bb474f93-4f17-456d-994c-6a89d542ff62"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3405ea74-1cf9-48a9-b3a6-dbbc947da3c9"), true, 5201, new Guid("f63346a8-fae7-413c-bff2-dbf4a0edf209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2017, new Guid("fe270392-7b99-459b-8cdf-77f0cccad02e"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("38df7431-ef6c-43bc-93f9-dba9287c9616"), true, 5601, new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2020, new Guid("bcff7aec-f9b2-4cad-afae-5abfe7e57752"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("39b8de9b-ba19-4ed1-af59-235d5e226d74"), true, 4801, new Guid("65f8ca71-a5a5-401e-855c-6b1ce1f58aae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("cf8e0ecb-330f-4f21-9737-05c28396d3c5"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4458c29e-8e24-4922-a32e-835a1f20ae7c"), true, 4501, new Guid("a15c2636-4997-4580-84eb-5c1c3ab13812"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("b4350dd3-5850-461e-b91c-43167e657312"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4f9475df-7b7c-4d26-992d-95ff81a8acfe"), true, 2501, new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2001, new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("50b6de85-f7c5-48f3-b31c-3a22b020522d"), true, 5701, new Guid("0bc39c50-440e-4dd6-a06f-7ee0ddbf36bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2022, new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5b369855-f052-4fea-9309-2380d8eaa3ec"), true, 1401, new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("0dc2f9fc-33ca-4bb4-a700-a84333ffdafd"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5cc19040-5835-48db-8114-ec5c428dbc93"), true, 1301, new Guid("e3553e15-459c-4585-9790-00421af356e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2004, new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("61f09e0e-4235-4c0d-a609-6dfca3ecd265"), true, 2301, new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("631e9828-0ff0-4fd1-be3c-29bc638dbbc7"), true, 2901, new Guid("1ad5e814-119c-4323-a613-87e99873e67f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("667b7c1b-bcab-4543-97c8-35ea95b6c262"), true, 201, new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("68124303-9600-4930-8641-9a6907089ed2"), true, 2001, new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2005, new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7021da1c-8cc1-4e61-b309-37007d846fd8"), true, 5501, new Guid("0c05a0aa-b969-4bc9-8c35-bddb6618d49d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("bd68b365-7014-4b4b-9feb-15cfedc63b6c"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7f9b56e0-5730-47c4-92ff-36e276f9e8aa"), true, 4101, new Guid("8d61fbb6-c622-478e-9496-18f2f79d9bd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2016, new Guid("bb474f93-4f17-456d-994c-6a89d542ff62"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8690a7e0-1e35-44fe-8493-951858409f82"), true, 3201, new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2005, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8e79b45f-363e-40d7-bb5b-b01564673d46"), true, 4701, new Guid("ea21bddd-6675-466c-86ee-c02f3619e456"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1997, new Guid("36b9ad0c-2bc9-40c7-9f83-6187fc76cbfd"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f0528ef-af34-4d48-ae4c-d77f466a1cd0"), true, 101, new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2014, new Guid("1f855264-06ea-45d1-a83d-75ace379a617"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("97510b70-4597-4424-86e1-f3b179758378"), true, 5901, new Guid("4da9369d-9d97-413d-9d79-ac7c7996325f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2021, new Guid("27979172-3cfe-4167-950f-b96b9f2ff157"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("98dcb400-ac35-47b2-93d6-336c84a4148e"), true, 2801, new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9e7e9c8f-a628-4645-9312-1b2aaaf81693"), true, 401, new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9fd9475e-9d10-446d-a8a5-17f16a2ad9fa"), true, 4601, new Guid("b8f3641d-a07e-40c2-9e50-af86150a1105"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2012, new Guid("f9da53f1-6b24-4d3e-b4c8-a39ec264f405"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2850657-4d26-4836-9ab5-740f78ec0246"), true, 4201, new Guid("c13049c8-2291-45fd-9858-22d8601c6edc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2003, new Guid("4119a4e3-0d37-44e3-8bf4-6674f9964c7d"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2ca5e87-bdab-4e6a-a01f-7ad68d96cdc1"), true, 6201, new Guid("132c3c7c-29d7-4f1f-a439-2e6448fa2d05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2012, new Guid("1e9f7f17-65dd-41ff-9b2a-a1466c0a08a9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a6ddfe92-6a3f-4ab2-ab9e-637c025bafd3"), true, 601, new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ac00c36f-9231-4102-b1db-46bcbb73dcaa"), true, 2201, new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b1cffbd3-7a91-43bb-b83d-d44a60f87886"), true, 3001, new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2006, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "TEBookCopy",
                columns: new[] { "Id", "Active", "BookCopyNumber", "BookID", "DateChanged", "DateCreated", "IsAvailable", "Location", "PublishedYear", "PublisherID", "QRCodeUrl", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("b74b6e67-ef13-4b39-bd91-cddc12e26f97"), true, 5101, new Guid("dca46393-c568-4001-8e23-3a2e0492d4e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009, new Guid("47000d6e-2200-4b94-a2e7-1521be3aecef"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b7585ada-9bf8-40db-a7dc-a06446d812dd"), true, 701, new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2001, new Guid("9a9a0836-c01f-461d-a361-15b3244af1e5"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c478906c-fe3b-4ece-98df-bdfc504dcaef"), true, 1901, new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2007, new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c5b30ab6-ba5e-4b99-b5ed-bf8939ad6d2c"), true, 1802, new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2020, new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c90f7269-8d3c-48a1-819d-b489e3ed55f5"), true, 4901, new Guid("aa5dafc9-7995-44b0-8f09-281c836a455c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2002, new Guid("3e34d509-cfc8-4a36-b7a7-fcd38e3b1c37"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cbc51740-bfad-4a10-a211-8d348eefbf89"), true, 4401, new Guid("4c72342e-50c0-499c-a3d5-b057d981c280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2004, new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2035f18-1ef1-42bb-88c1-2a0d9d7cc9a1"), true, 5801, new Guid("285f548e-a3ff-4dea-b02b-3d423ba0061f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2000, new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e8984883-4ff0-475f-8c62-d49703f55faa"), true, 2601, new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1999, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ec7eb3a5-e1b9-430f-803b-a7022f0a1ff4"), true, 5001, new Guid("2502db5e-3b84-4b1f-be4c-242521e06664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2015, new Guid("b668a744-31f0-49d7-9547-a21830398a5b"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ef045303-34e3-42eb-80e0-2d19d98adeb8"), true, 3101, new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2005, new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f42833e6-8c64-4c06-9425-046f835dfff4"), true, 1101, new Guid("aa849042-ecd7-476d-b296-610c83240ad0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1999, new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ff3de804-df06-4508-9b54-537ca53f4c20"), true, 6001, new Guid("c730eedf-d6b7-4b25-b89c-fc5ab9e5b9a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2008, new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "96312617-dd65-4d06-aa23-619962c041d7");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "7ffadd45-0b73-4fe8-8be4-15a5344303bf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("05cd618c-a0b7-45f3-bb2c-b5d3aa19c5c3"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("069dfe07-5e1c-44f9-8e4e-7de4cbf69939"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("0afe1532-d865-4b7f-9ac2-c78ebc345ded"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("0fc6e2b9-8de6-47e1-9062-06e8485bbda9"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("17b15180-8084-4c4b-baed-e6267fcb03b7"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("1a727083-e283-4bcb-bd04-7f679e37d6ea"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("1c814007-2090-446d-ad5a-91620eb3ace7"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("1e598e8e-0f76-42b3-9e79-5a4655890043"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("1ef15ca3-496b-444b-bc30-d6e2984da5d9"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("1fae4f73-4673-4f4f-8eb9-fdd2eed487d2"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("230884ea-0f24-42b7-8f85-b7abc58b5bc3"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("27794355-9c6f-41d4-9bac-f0bed748ddb4"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("2964fd4a-5d4a-41ab-bf76-5e2d58be8919"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("2cb6c4cf-a628-458b-ac59-54c5295e91d9"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("2e6dd7bd-e633-4793-85da-55bd18212dff"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("2fb51db3-a1a0-486d-a8c7-ed6b0b102850"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("3405ea74-1cf9-48a9-b3a6-dbbc947da3c9"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("38df7431-ef6c-43bc-93f9-dba9287c9616"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("39b8de9b-ba19-4ed1-af59-235d5e226d74"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("4458c29e-8e24-4922-a32e-835a1f20ae7c"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("4f9475df-7b7c-4d26-992d-95ff81a8acfe"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("50b6de85-f7c5-48f3-b31c-3a22b020522d"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("5b369855-f052-4fea-9309-2380d8eaa3ec"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("5cc19040-5835-48db-8114-ec5c428dbc93"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("61f09e0e-4235-4c0d-a609-6dfca3ecd265"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("631e9828-0ff0-4fd1-be3c-29bc638dbbc7"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("667b7c1b-bcab-4543-97c8-35ea95b6c262"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("68124303-9600-4930-8641-9a6907089ed2"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("7021da1c-8cc1-4e61-b309-37007d846fd8"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("7f9b56e0-5730-47c4-92ff-36e276f9e8aa"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("8690a7e0-1e35-44fe-8493-951858409f82"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("8e79b45f-363e-40d7-bb5b-b01564673d46"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("8f0528ef-af34-4d48-ae4c-d77f466a1cd0"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("97510b70-4597-4424-86e1-f3b179758378"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("98dcb400-ac35-47b2-93d6-336c84a4148e"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("9e7e9c8f-a628-4645-9312-1b2aaaf81693"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("9fd9475e-9d10-446d-a8a5-17f16a2ad9fa"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("a2850657-4d26-4836-9ab5-740f78ec0246"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("a2ca5e87-bdab-4e6a-a01f-7ad68d96cdc1"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("a6ddfe92-6a3f-4ab2-ab9e-637c025bafd3"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("ac00c36f-9231-4102-b1db-46bcbb73dcaa"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("b1cffbd3-7a91-43bb-b83d-d44a60f87886"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("b74b6e67-ef13-4b39-bd91-cddc12e26f97"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("b7585ada-9bf8-40db-a7dc-a06446d812dd"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("c478906c-fe3b-4ece-98df-bdfc504dcaef"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("c5b30ab6-ba5e-4b99-b5ed-bf8939ad6d2c"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("c90f7269-8d3c-48a1-819d-b489e3ed55f5"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("cbc51740-bfad-4a10-a211-8d348eefbf89"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("e2035f18-1ef1-42bb-88c1-2a0d9d7cc9a1"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("e8984883-4ff0-475f-8c62-d49703f55faa"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("ec7eb3a5-e1b9-430f-803b-a7022f0a1ff4"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("ef045303-34e3-42eb-80e0-2d19d98adeb8"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("f42833e6-8c64-4c06-9425-046f835dfff4"));

            migrationBuilder.DeleteData(
                table: "TEBookCopy",
                keyColumn: "Id",
                keyValue: new Guid("ff3de804-df06-4508-9b54-537ca53f4c20"));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddData_to_TEBookSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBook",
                columns: new[] { "Id", "Active", "BookIndex", "DateChanged", "DateCreated", "Description", "GenreID", "Language", "Name", "PageAmount", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("0a4604ea-9aa8-4338-a95d-318f67d5362d"), true, 4000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With the critical Key Performance Indicators required to understand your employees, financials and customers, this book tells you what you need to know, fast.	", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "25 need - to - know key performance indicators", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0bc39c50-440e-4dd6-a06f-7ee0ddbf36bf"), true, 5700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to Reduce Code Complexity and Develop Software More Sustainably", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Code That Fits in Your Head : Heuristics for Software Engineering  ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0c05a0aa-b969-4bc9-8c35-bddb6618d49d"), true, 5500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Now 'the secret' is being shared with the world.Beautiful in its simplicity, and mind - dazzling in its ability to really work, The Secret reveals the mystery of the hidden potential within us all. By unifying leading - edge scientific thought with ancient wisdom and spirituality, the riveting, practical knowledge will lead readers to a greater understanding of how they can be the masters of their own lives.", new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), null, "The Secret: Skrivnost", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("132c3c7c-29d7-4f1f-a439-2e6448fa2d05"), true, 6200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Zasebnost in varovanje osebnih podatkov, 2.del ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1a40d746-6b93-4e6c-b59d-100ad3209597"), true, 4300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master Key System temelji na znanstvenih resnicah in omogoča razvoj posameznikovih sposobnosti. S posameznimi koraki, ki se med seboj povezujejo in nadgrajujejo nas uči, kako svoje sposobnosti spremenimo v dejanja, kako povečamo osebno učinkovitost in kako si pridobimo več energije, življenjske moči, postanemo bistroumnejši in umsko prožnejši.", new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), null, "Master key system: tečaj samouresničitve   ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2502db5e-3b84-4b1f-be4c-242521e06664"), true, 5000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kako obvladati strankine izgovore in doseči, da bo kupila pri vas ?", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Zaključevanje prodajnih pogajanj   ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("285f548e-a3ff-4dea-b02b-3d423ba0061f"), true, 5800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "OD IDEJE DO DENARJA: Podjetniški proces    ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"), true, 5600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "he Flow System is a holistic FLOW based approach to delivering Customer 1st Value. It is built on a foundation of the Toyota Production System(TPS / LEAN) and the new Triple Helix of Flow creating the DNA of Organizations.	", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "The Flow System: The Evolution of Agile and Lean Thinking in an Age of Complexity  ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4c72342e-50c0-499c-a3d5-b057d981c280"), true, 4400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Drucker, eden vodilnih piscev o praksi in teoriji managementa, je skoraj pol stoletja pisal za managerje in vplival na naravo poslovanja podjetij in organizacij.V knjigi je objavljen izbor najboljših Druckerjevih člankov, ki so bili objavljeni v reviji Harvard Business Review med letoma 1950 in 1995.", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "O managementu", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4da9369d-9d97-413d-9d79-ac7c7996325f"), true, 5900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "C# 10 and .NET 6 – Modern Cross-Platform Development", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("65f8ca71-a5a5-401e-855c-6b1ce1f58aae"), true, 4800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ko znaš prodajati, znaš ustvariti dohodek kadarkoli in kjerkoli.Prodaja je srce vsakega posla.Ni treba da ste napadalen pes, da bi uspeli v prodaji.", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Psi prodaje", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7dd9600e-f823-4472-90ea-6e801cd722e5"), true, 6100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Zasebnost in varovanje osebnih podatkov", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8d61fbb6-c622-478e-9496-18f2f79d9bd1"), true, 4100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Using the science of strategy, The Strategy Book will help you tackle the really important challenges you face both in developing strategies and putting them into action.Its aim is to give you best ideas wrapped up in a usable, enjoyable package.", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "The Strategy Book, 2nd Edition ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a15c2636-4997-4580-84eb-5c1c3ab13812"), true, 4500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "After years of reading, evaluating, and selling business books, Jack Covert and Todd Sattersten are among the most respected experts on the category. Now they have chosen and reviewed the one hundred best business titles of all time—the ones that deliver the biggest payoff for today’s busy readers.", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "The 100 Best Business Books of All Time: What They Say, Why They Matter, and How They Can Help You ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9830403-ee09-4cc7-a8b4-84149a961297"), true, 3900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "O uspehu se ne govori.Martin Limbeck pa ni skromen.Na glas si upa povedati, da mu je uspelo. Še več. Pove, kako je uspelo njemu in kako lahko tudi nam.	", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Skrivnosti vrhunskega prodajalca", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("aa5dafc9-7995-44b0-8f09-281c836a455c"), true, 4900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Ste za akcijo  ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b8f3641d-a07e-40c2-9e50-af86150a1105"), true, 4600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hank Haney's candid, surprisingly insightful account of his tumultuous six-year journey with Tiger Woods, during which the supremely gifted golfer collected six major championships and rewrote golf history. Hank was one of very few people allowed behind the curtain and observed Tiger in nearly every circumstance. There's never been a book about Tiger that is as intimate and revealing--or as wise about what it takes to coach a star athlete.", new Guid("dad56ba5-640c-4ec1-accb-35463c824b12"), null, "The Big Miss: My Years Coaching Tiger Woods", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c13049c8-2291-45fd-9858-22d8601c6edc"), true, 4200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wake up and take control of your life!From the bestselling author of Inner Strength, Unlimited Power, and MONEY Master the Game, Anthony Robbins, the nation's leader in the science of peak performance, shows you his most effective strategies and techniques for mastering your emotions, your body, your relationships, your finances, and your life.	", new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), null, "Awaken the Giant Within", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c5f70a82-af6e-4eb5-a22a-b26a0c268664"), true, 5300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Priročnik ISO 9001:2015: Razumevanje in izvajanje novih zahtev", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c730eedf-d6b7-4b25-b89c-fc5ab9e5b9a1"), true, 6000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Ekonomija podjetja ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dca46393-c568-4001-8e23-3a2e0492d4e0"), true, 5100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "   ", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Revolucija z inovativnostjo do uspeha! 1.del   ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ea21bddd-6675-466c-86ee-c02f3619e456"), true, 4700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The only text to strike a balance between solid financial theory and practical applications, Brigham / Ehrhardt�s FINANCIAL MANAGEMENT: THEORY AND PRACTICE, 15e gives you a thorough understanding of the essential concepts you need to develop and implement effective financial strategies.The book begins with a presentation of corporate finance fundamentals before progressing to discussions of specific techniques used to maximize the value of a firm.It also explores the recent financial and economic crises and the role of finance in the business world.With its relevant and engaging presentation, numerous examples, and emphasis on Excel usage, this text serves as a complete reference tool for you in your academic or business career.The 15th edition is also available with MindTap Finance to help you to become First in Finance.", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Financial Management: Theory and Practice  ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1d159ac-e050-47b8-8cf4-dcecd095ef91"), true, 5400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skrivnost sladkega uspeha v poslu in življenju Uspešni ljudje se zavedajo, da morajo za dosego tistega, česar si res želijo, ponujeno pogosto preložiti. Avtorja nas v očarljivem slogu poučita, kako z načrtovanimi in postopnimi koraki pridemo do točke, ko lahko rečemo: ‚Zmagal sem!‘ 	", new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), null, "Ne vseh bonbonov hkrati!   ", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f63346a8-fae7-413c-bff2-dbf4a0edf209"), true, 5200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiga Prodaja, z ambicioznim podnaslovom Biblija vrhunskega prodajnika, vam zagotavlja konkretne korake za doseganje vrhunskih rezultatov. V knjigi najdete primere uspešnega pogajanja, upravljanja z ugovori, primere postavljanja kraljevskih vprašanj in v prvi vrsti metode, ki vas popeljejo do zaključka prodaje že na začetku prodajnega sestanka. Dodana vrednost knjige je zagotovo praktična naravnanost obeh avtorjev, ki sta v prodajo vsakodnevno vključena tudi sama.	", new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), null, "Prodaja. : strategije prihodnosti : Top selling professional: biblija vrhunskega prodajnika", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("0a4604ea-9aa8-4338-a95d-318f67d5362d"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("0bc39c50-440e-4dd6-a06f-7ee0ddbf36bf"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("0c05a0aa-b969-4bc9-8c35-bddb6618d49d"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("132c3c7c-29d7-4f1f-a439-2e6448fa2d05"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("1a40d746-6b93-4e6c-b59d-100ad3209597"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("2502db5e-3b84-4b1f-be4c-242521e06664"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("285f548e-a3ff-4dea-b02b-3d423ba0061f"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("41b94a0e-75a7-47ec-8b6a-c39ecb2c99a9"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("4c72342e-50c0-499c-a3d5-b057d981c280"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("4da9369d-9d97-413d-9d79-ac7c7996325f"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("65f8ca71-a5a5-401e-855c-6b1ce1f58aae"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("7dd9600e-f823-4472-90ea-6e801cd722e5"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("8d61fbb6-c622-478e-9496-18f2f79d9bd1"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a15c2636-4997-4580-84eb-5c1c3ab13812"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a9830403-ee09-4cc7-a8b4-84149a961297"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("aa5dafc9-7995-44b0-8f09-281c836a455c"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("b8f3641d-a07e-40c2-9e50-af86150a1105"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c13049c8-2291-45fd-9858-22d8601c6edc"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c5f70a82-af6e-4eb5-a22a-b26a0c268664"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c730eedf-d6b7-4b25-b89c-fc5ab9e5b9a1"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("dca46393-c568-4001-8e23-3a2e0492d4e0"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("ea21bddd-6675-466c-86ee-c02f3619e456"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("f1d159ac-e050-47b8-8cf4-dcecd095ef91"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("f63346a8-fae7-413c-bff2-dbf4a0edf209"));

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
    }
}

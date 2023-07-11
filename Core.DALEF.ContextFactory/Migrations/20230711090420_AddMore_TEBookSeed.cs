using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class AddMore_TEBookSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TEBook",
                columns: new[] { "Id", "Active", "BookIndex", "DateChanged", "DateCreated", "Description", "GenreID", "Language", "Name", "PageAmount", "UserChangedID", "UserCreatedID" },
                values: new object[,]
                {
                    { new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"), true, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Postanite sam svoj vodja\r\n\r\nKako v 5 korakih povecati ucinkovitost vašega dela", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Mravlja in slon", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"), true, 3200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kako hitro in manj stresno zaslužiti vec", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Prodajajte odgovorno", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1ad5e814-119c-4323-a613-87e99873e67f"), true, 2900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Namesto da išcete službo, zacnite iskati priložnosti", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "V odvisnosti od službe", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1bdbc2a2-488a-412e-b047-82de20caab26"), true, 1700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pricujoca knjiga je namenjena vodstvenim delavcem, svetovalcem in podjetnikom, ki želijo postati ucinkoviti vodje in vsem, ki razmišljajo o zamenjavi službe, ki se s težavo soocajo s spremembami in išcejo nove možnosti za razvoj in napredek tako na poslovnem kot osebnem podrocju", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Ucinkoviti vodja", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), true, 1800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Digitalna transformacija in poslovne informacijske rešitve", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3678e8e4-7716-42ae-98a2-277adab4bccc"), true, 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 cudovitih nacinov, da prenehate prelagati na jutri, kar lahko storite danes, in v manj casa opravite vec", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Pojej živo žabo", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), true, 2800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chandler in Beckford razgaljata devet najpogostejših (in ponavadi usodnih) poslovnih mitov in ponujata preproste in navdihujoce rešitve za težave, ki si jih samostojni podjetniki ter lastniki majhnih podjetij povzrocajo iz dneva v dan. Presenetljive resnice, ki predstavljajo protistrup tem lažem, so Sam Beckford in vec sto njegovih strank, uspešnih samostojnih podjetnikov ter lastnikov majhnih podjetij, sami preizkusili\r\n\r\nTo sveže, živahno \"sveto pismo za poslovneže\" vam bo razkrilo, kaj in kako morate poceti, da bi vaš posel postal dobickonosen. V knjigi boste  odkrili tudi sestavino, ki v mnogih \"prakticnih\" poslovnih prirocnikih manjka - kako se iz dneva v dan motivirati, da bi te stvari dejansko lahko poceli", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "9 laži, zaradi katerih vaš posel ne uspeva, kot bi lahko... in resnica, ki ga bo osvobodila", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"), true, 3500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uspeha ne bo, ce boste nanj cakali. Knjiga vam bo razkrila, kaj morate storiti, da bi se zgodila prave stvari.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Brez tveganja ni uspeha", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"), true, 3000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30 prodajnih orodij, s katerimi lahko nadzorujete misli vaše stranke, jo motivirate, vplivate nanjo in jo prepricate v nakup.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Sprožilci", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"), true, 3100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Razmerje med ceno in dobickom in kaj to pomeni za vaše podjetje", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Cena priložnosti", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), true, 3400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kako posameznike povezati v uspešen tim!", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Zmagovalci", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), true, 1400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kako obvladovati cas in ponovno vzpostaviti ravnotežje v življenju", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Hiti pocasi", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"), true, 1900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Najucinkovitejši pogovor je sestavljen iz 20 % odgovorov in 80 % spraševanja", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Osnovne vešcine postavljanja vprašanj", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), true, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ce ste kot vecina ljudi, uporabljate samo okoli deset odstotkov svojega potenciala, ostalih devetdeset odstotkov pa spada v kategorijo \"lahko bi\"", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Recite DA svojemu potencialu", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), true, 2600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skozi situacije iz resnicnega življenja in prek zabavnih osebnih anekdot vam Littauerjevi pokažeta, kako naj bi se najbolje odzvali na reakcijo prijateljev in sodelavcev. Vam ni jasno, zakaj je vaš partner užaljen? Se sprašujete, zakaj se je kolegica tako \"cudno\" oblekla? Vas zanima, koga postaviti na novo delovno mesto? Kakšne oglase napisati za razlicne tipe ljudi? Komu zaupati rutinsko delo? Kdo bo bolje opravil kreativni del naloge? Kako to, da je sodelavec nervozen, ceprav rok za izvedbo projekta potece šele cez en mesec? To je le nekaj vprašanj, na katere boste v knjigi našli številne koristne odgovore", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Osebnostna sestavljanka", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"), true, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27 nacinov, kako spremeniti neuspeh v uspeh \r\n\r\nRecepti za ustvarjalno, uspešno in mirno življenje", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Moc neuspeha", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), true, 3800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaj vedo in pocnejo odlicni vodje\r\n\r\nV knjigi boste izvedeli:\r\n- kaj morate narediti, da boste resnicno navdihnili in motivirali druge ljudi\r\n- zakaj dobre vodje skrbi prihodnost\r\n- katera tri podrocja zahtevajo stalne izboljšave\r\n- kako lahko znatno okrepite svojo vodstveno kredibilnost - ali pa jo nezavedno unicite\r\n- kateri dve komponenti sta bistveni za resnicen uspeh in vodenje - in še veliko vec.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Skrivnost", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("96856727-b094-4e6f-941c-d15bf44d766f"), true, 3700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "'A very practical, engaging guide to the essential tools which managers at all levels need to be effective themselves and to develop others. Highly recommended.' Stuart Chambers, former CEO of Pilkington plc       Key Management Development Models gives you, at a glance, instant access to a full range of the best models available for developing your management skills and helping others to work and perform at their peak.       For anyone seeking to develop their management skills it can be hard to know where to begin. Key Management Development Models explains the tools in detail - what they are and when and how to use them, with key practical tips. It's like having your very own management development coach on hand explaining all the tools that you will ever need to know. EXPERT GUIDANCE FOR YOUR MANAGEMENT CAREER", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Key Management Development Models Travel", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"), true, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Šest pozitivnih povezav z uspehom", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Pozitivni naboj", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"), true, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Postanite uspešnejši in ustvarite življenje, ki si ga želite", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Pozitivna naravnanost in ustvarjalnost pri delu", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a50e2b66-93b3-4a7c-9642-52bfe9959a7e"), true, 2700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Je pot...\r\nSo cilji...\r\nSo želje...\r\n\r\nZakaj je motivacija cudež?\r\n\r\nKer z njo uspete...\r\nKer z njo premagate težave...\r\nKer z njo dosežete vaše življenjske cilje...", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Cudež motivacije", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a770ffb6-a764-446b-b9ff-6cd966c92147"), true, 3600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to handle everything (and everyone) around you when all hell breaks loose, from the international bestselling author of Surrounded by Idiots . Not everything goes the way we want it to - the world or people around us sometimes just spin out of control. Just consider the Covid pandemic for starters. Or how about that mad neighbour you have living next-door to you? Or when work seems to be going down the toilet when the competition keep outsmarting you? So how do you handle everything life throws your way when you'd really prefer to tell everyone to get stuffed?Thomas Erikson will help you turn adversity into success with the help of the behavioural model made famous in Surrounded by Idiots . Starting by reminding us that life is as it is, Erikson helps you see that it is in fact useless to try to control everything happening around you. Instead of protesting when life throws you curveballs, focus instead on how to handle them. Just as you keep the weeds away from the garden to provide space and amazing flowers, you need to find an approach to adversity that works for you and will give you the chance to turn everything into success. Surrounded by Setbacks will help you pinpoint the approach that works for you and will entertain and empower you in equal measure.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Surrounded by Setbacks", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("aa849042-ecd7-476d-b296-610c83240ad0"), true, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enostavne, znanstven, revolucionaren program za zdravje in uspeh slovitega ameriškega zdravnika", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Psiho-kibernetika", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"), true, 2300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaj je današnja najvecja težava?\r\nPomanjkanje casa!\r\nO tem govorijo vsi. POmanjkanje casa skrbi vse nas, a doslej ni še nihce ponudil rešitve, kako to težavo odpraviti.\r\n\r\nZakaj ljudem primanjkuje casa?\r\nKer svoj cas v službi menjajo za denar. Denar potrebujejo, zato \"prodajajo\" svoj cas. POtrebujejo vec denarja, zato prodajajo vec casa. Kmalu toliko casa namenijo služenju denarja, da imajo bore malo casa za karkoli drugega.\r\n\r\nKakšna je rešitev?\r\nSvoj cas zacnite menjati za KAPITAL, ki mu potem dopustite, naj dela za vas in vam prinaša prihodke, ki jih potrebujete za uresnicitev svojih sanj. Tako boste imeli vec casa za pomembne stvari, cas za družino in prijatelje, cas za rekreacijo in cas za užvanje življenja.\r\n\r\nBill Quain v svoji knjigi ljudem pojasni, zakaj nimajo casa. Potem pa svojim bralcem predstavi pet preprostih korakov, kako lahko delajo manj, ustvarijo vec in premagajo casovno revšcino.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Kako premagati casovno revšcino", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"), true, 3300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pot do vašega osebnega uspeha", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Zmagovalni odnos", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c05bc45d-013a-497a-83f5-1ca7418f1011"), true, 2400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ta knjiga, od katere se ne boste mogli lociti, vam bo pomagala slediti in uresnicevati vaše sanje. Pat Mesiti vam na zabaven in izzivalen nacin pokaže, kako:\r\n- napacna dojemanja zamenjate z zmagovalnimi pristopi\r\n- pridobite nove prijatelje\r\n- sami dolocite svojo usodo\r\n- presežete meje svojih sposobnosti\r\n- premagate neuspeh\r\n- odkrijete, kaj je pravi uspeh in kako preoblikuje vaš svet", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Sanjaci nikoli ne spijo", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"), true, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Razvijanje vašega vpliva od kjerkoli znotraj posamezne organizacije", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "360° vodja", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), true, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Znanstveniki so odkrili skrivnost zdravega in trajnega hujšanja, ki sploh nima opravka z dieto!\r\n\r\nLjudje imajo cezmerno telesno težo, ker so ujetniki škodljivih navad. Priricnik Dieta brez diete vam pokaže, kako se lahko znebite skritih navad, da boste shujšali brez truda in obcutka lakote.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Dieta brez diete", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), true, 2200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Želja, da bi nas drugi prepoznali, da bi se cutili bolj pomembne in cenjene, najbolj prevladuje. In bolj pomembne ko se drugi pocutijo ob vas, bolj pozitivno se bodo odzvali na vas", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Kako spretno komunicirati z ljudmi", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), true, 2100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kratek vodnik ponuda konkretne odgovore, kako:\r\n- Uporabiti štiri edinstvena podrocja custvene inteligence: samozavedanje, samoupravljanje, družbeno zavedanje in upravljanje medosebnih odnosov\r\n- Dvigniti raven custvene inteligence s tehnikami usposabljanja\r\n- Uporabiti custveno inteligenco pri delu za razvoj sposobnosti vodenja in izboljšanje ucinkovitosti timskega dela, kar nam omogoca, da postanemo boljši vodja oziroma bolj priljubljen sodelavec\r\n- Uporabiti custveno inteligenco v praksi izven delovnega okolja z najbližjimi, tako da postanemo boljši partnerji in starši\r\n- Doseci povezavo med custveno inteligenco in dobrim telesnim pocutjem\r\n- Izmeriti trenutno raven custvene inteligence s preizkusom na spletu", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Custvena inteligenca", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"), true, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikoli vec ne boste rekli, da imate slab spomin za imena in obraze", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Zapomnite si vsako ime", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), true, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Skrivnost ustvarjalnega tima", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e3553e15-459c-4585-9790-00421af356e1"), true, 1300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tudi vi lahko v življenju \"rastete\" - ne pa ga samo preživljate - premagate nemogoce okolišcine in dosežete sreco in uspeh! \r\nDramaticna življenska zgodba Mammie McCullough nazorno dokazuje, da pozitivno mišljenje ni samo nadve ucinkovito, marvec nam prinaša tudi globoko zadošcenje.", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Ce zmorem jaz, zmoreš tudi ti!", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"), true, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preprosta in ucinkovita metoda v 4. korakih, s katero se boste v vsakdanjem življenju lažje sporazumevali in dogovarjali", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Ucinkovito reševanje konfliktov", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"), true, 1600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Postanite voditelj", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"), true, 2500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Življenski nacrt za timske igralce", new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), null, "Notranji zmagovalec", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                column: "SecurityStamp",
                value: "d1970ff4-2f8f-4781-98c6-220a3d244e19");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                column: "SecurityStamp",
                value: "cb383e78-5e70-4f8b-a2ea-eced8c4ae5c7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("1ad5e814-119c-4323-a613-87e99873e67f"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("1bdbc2a2-488a-412e-b047-82de20caab26"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("3678e8e4-7716-42ae-98a2-277adab4bccc"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("96856727-b094-4e6f-941c-d15bf44d766f"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a50e2b66-93b3-4a7c-9642-52bfe9959a7e"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("a770ffb6-a764-446b-b9ff-6cd966c92147"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("aa849042-ecd7-476d-b296-610c83240ad0"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c05bc45d-013a-497a-83f5-1ca7418f1011"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("cd461206-e127-4b46-931f-f448623ea7b0"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("e3553e15-459c-4585-9790-00421af356e1"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"));

            migrationBuilder.DeleteData(
                table: "TEBook",
                keyColumn: "Id",
                keyValue: new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"));

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
    }
}

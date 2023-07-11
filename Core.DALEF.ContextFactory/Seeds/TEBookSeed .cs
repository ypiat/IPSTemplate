﻿
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Net.NetworkInformation;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEBookSeed : List<TEBook>
    {
        public TEBookSeed()
        {
            Add(new() { Id = new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"), Name = "Free! Love Your Work, Love Your Life", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Life and work are intrinsically linked. They are not separate; they are one. If we want to live an extraordinary life, we have to make our work equally extraordinary. When your work resonates with purpose, you jump out of bed every morning, excited by the possibilities the day holds for you. Everything else in your life seems to have a glow about it, and you exude much more personal shine. My aim in writing this book is to help you feel like that every day. To help you make your work work for you. To feel truly free. Reading Free! will remind you that you are fantastic and have the ability to do amazing things; show you that work is your slave, not the other way round; help you make work your ticket to an extraordinary future; and put you in the driving seat and show you a route to freedom.", BookIndex = 100 });
            Add(new() { Id = new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"), Name = "Clean Code: A Handbook of Agile Software Craftsmanship", GenreID = new Guid("E74EC0D0-4F62-424A-A876-1ED6815E9DE5"), Active = true, Description = "Even bad code can function. But if code isn&rsquo;t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn&rsquo;t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with  Clean Code: A Handbook of Agile Software Craftsmanship . Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code &ldquo;on the fly&rdquo; into a book that will instill within you the values of a software craftsman and make you a better programmer&mdash;but only if you work at it. What kind of work will you be doing? You&rsquo;ll be reading code&mdash;lots of code. And you will be challenged to think about what&rsquo;s right about that code, and what&rsquo;s wrong with it. More importantly, you will be challenged to reassess your professional values and your commitment to your craft.   Clean Code  is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code&mdash;of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and &ldquo;smells&rdquo; gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code. Readers will come away from this book understanding  How to tell the difference between good and bad code How to write good code and how to transform bad code into good code How to create good names, good functions, good objects, and good classes How to format code for maximum readability How to implement complete error handling without obscuring code logic How to unit test and practice test-driven development This book is a must for any developer, software engineer, project manager, team lead, or systems analyst with an interest in producing better code.", BookIndex = 200 });
            Add(new() { Id = new Guid("3678e8e4-7716-42ae-98a2-277adab4bccc"), Name = "Pojej živo žabo", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "21 cudovitih nacinov, da prenehate prelagati na jutri, kar lahko storite danes, in v manj casa opravite vec", BookIndex = 300 });
            Add(new() { Id = new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"), Name = "360° vodja", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Razvijanje vašega vpliva od kjerkoli znotraj posamezne organizacije", BookIndex = 400 });
            Add(new() { Id = new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"), Name = "Moc neuspeha", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "27 nacinov, kako spremeniti neuspeh v uspeh \r\n\r\nRecepti za ustvarjalno, uspešno in mirno življenje", BookIndex = 500 });
            Add(new() { Id = new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"), Name = "Ucinkovito reševanje konfliktov", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Preprosta in ucinkovita metoda v 4. korakih, s katero se boste v vsakdanjem življenju lažje sporazumevali in dogovarjali", BookIndex = 600 });
            Add(new() { Id = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Name = "Skrivnost ustvarjalnega tima", GenreID = new Guid("9147B105-9B2B-4D11-8F19-64D2A588CD44"), Active = true, Description = "", BookIndex = 700 });
            Add(new() { Id = new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"), Name = "Pozitivna naravnanost in ustvarjalnost pri delu", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Postanite uspešnejši in ustvarite življenje, ki si ga želite", BookIndex = 800 });
            Add(new() { Id = new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"), Name = "Pozitivni naboj", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Šest pozitivnih povezav z uspehom", BookIndex = 900 });
            Add(new() { Id = new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"), Name = "Mravlja in slon", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Postanite sam svoj vodja\r\n\r\nKako v 5 korakih povecati ucinkovitost vašega dela", BookIndex = 1000 });
            Add(new() { Id = new Guid("aa849042-ecd7-476d-b296-610c83240ad0"), Name = "Psiho-kibernetika", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Enostavne, znanstven, revolucionaren program za zdravje in uspeh slovitega ameriškega zdravnika", BookIndex = 1100 });
            Add(new() { Id = new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), Name = "Recite DA svojemu potencialu", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Ce ste kot vecina ljudi, uporabljate samo okoli deset odstotkov svojega potenciala, ostalih devetdeset odstotkov pa spada v kategorijo \"lahko bi\"", BookIndex = 1200 });
            Add(new() { Id = new Guid("e3553e15-459c-4585-9790-00421af356e1"), Name = "Ce zmorem jaz, zmoreš tudi ti!", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Tudi vi lahko v življenju \"rastete\" - ne pa ga samo preživljate - premagate nemogoce okolišcine in dosežete sreco in uspeh! \r\nDramaticna življenska zgodba Mammie McCullough nazorno dokazuje, da pozitivno mišljenje ni samo nadve ucinkovito, marvec nam prinaša tudi globoko zadošcenje.", BookIndex = 1300 });
            Add(new() { Id = new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), Name = "Hiti pocasi", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Kako obvladovati cas in ponovno vzpostaviti ravnotežje v življenju", BookIndex = 1400 });
            Add(new() { Id = new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), Name = "Dieta brez diete", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Znanstveniki so odkrili skrivnost zdravega in trajnega hujšanja, ki sploh nima opravka z dieto!\r\n\r\nLjudje imajo cezmerno telesno težo, ker so ujetniki škodljivih navad. Priricnik Dieta brez diete vam pokaže, kako se lahko znebite skritih navad, da boste shujšali brez truda in obcutka lakote.", BookIndex = 1500 });
            Add(new() { Id = new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"), Name = "Postanite voditelj", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "", BookIndex = 1600 });
            Add(new() { Id = new Guid("1bdbc2a2-488a-412e-b047-82de20caab26"), Name = "Ucinkoviti vodja", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Pricujoca knjiga je namenjena vodstvenim delavcem, svetovalcem in podjetnikom, ki želijo postati ucinkoviti vodje in vsem, ki razmišljajo o zamenjavi službe, ki se s težavo soocajo s spremembami in išcejo nove možnosti za razvoj in napredek tako na poslovnem kot osebnem podrocju", BookIndex = 1700 });
            Add(new() { Id = new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), Name = "Digitalna transformacija in poslovne informacijske rešitve", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "", BookIndex = 1800 });
            Add(new() { Id = new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"), Name = "Osnovne vešcine postavljanja vprašanj", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Najucinkovitejši pogovor je sestavljen iz 20 % odgovorov in 80 % spraševanja", BookIndex = 1900 });
            Add(new() { Id = new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"), Name = "Zapomnite si vsako ime", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Nikoli vec ne boste rekli, da imate slab spomin za imena in obraze", BookIndex = 2000 });
            Add(new() { Id = new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), Name = "Custvena inteligenca", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Kratek vodnik ponuda konkretne odgovore, kako:\r\n- Uporabiti štiri edinstvena podrocja custvene inteligence: samozavedanje, samoupravljanje, družbeno zavedanje in upravljanje medosebnih odnosov\r\n- Dvigniti raven custvene inteligence s tehnikami usposabljanja\r\n- Uporabiti custveno inteligenco pri delu za razvoj sposobnosti vodenja in izboljšanje ucinkovitosti timskega dela, kar nam omogoca, da postanemo boljši vodja oziroma bolj priljubljen sodelavec\r\n- Uporabiti custveno inteligenco v praksi izven delovnega okolja z najbližjimi, tako da postanemo boljši partnerji in starši\r\n- Doseci povezavo med custveno inteligenco in dobrim telesnim pocutjem\r\n- Izmeriti trenutno raven custvene inteligence s preizkusom na spletu", BookIndex = 2100 });
            Add(new() { Id = new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), Name = "Kako spretno komunicirati z ljudmi", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Želja, da bi nas drugi prepoznali, da bi se cutili bolj pomembne in cenjene, najbolj prevladuje. In bolj pomembne ko se drugi pocutijo ob vas, bolj pozitivno se bodo odzvali na vas", BookIndex = 2200 });
            Add(new() { Id = new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"), Name = "Kako premagati casovno revšcino", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Kaj je današnja najvecja težava?\r\nPomanjkanje casa!\r\nO tem govorijo vsi. POmanjkanje casa skrbi vse nas, a doslej ni še nihce ponudil rešitve, kako to težavo odpraviti.\r\n\r\nZakaj ljudem primanjkuje casa?\r\nKer svoj cas v službi menjajo za denar. Denar potrebujejo, zato \"prodajajo\" svoj cas. POtrebujejo vec denarja, zato prodajajo vec casa. Kmalu toliko casa namenijo služenju denarja, da imajo bore malo casa za karkoli drugega.\r\n\r\nKakšna je rešitev?\r\nSvoj cas zacnite menjati za KAPITAL, ki mu potem dopustite, naj dela za vas in vam prinaša prihodke, ki jih potrebujete za uresnicitev svojih sanj. Tako boste imeli vec casa za pomembne stvari, cas za družino in prijatelje, cas za rekreacijo in cas za užvanje življenja.\r\n\r\nBill Quain v svoji knjigi ljudem pojasni, zakaj nimajo casa. Potem pa svojim bralcem predstavi pet preprostih korakov, kako lahko delajo manj, ustvarijo vec in premagajo casovno revšcino.", BookIndex = 2300 });
            Add(new() { Id = new Guid("c05bc45d-013a-497a-83f5-1ca7418f1011"), Name = "Sanjaci nikoli ne spijo", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Ta knjiga, od katere se ne boste mogli lociti, vam bo pomagala slediti in uresnicevati vaše sanje. Pat Mesiti vam na zabaven in izzivalen nacin pokaže, kako:\r\n- napacna dojemanja zamenjate z zmagovalnimi pristopi\r\n- pridobite nove prijatelje\r\n- sami dolocite svojo usodo\r\n- presežete meje svojih sposobnosti\r\n- premagate neuspeh\r\n- odkrijete, kaj je pravi uspeh in kako preoblikuje vaš svet", BookIndex = 2400 });
            Add(new() { Id = new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"), Name = "Notranji zmagovalec", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Življenski nacrt za timske igralce", BookIndex = 2500 });
            Add(new() { Id = new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), Name = "Osebnostna sestavljanka", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Skozi situacije iz resnicnega življenja in prek zabavnih osebnih anekdot vam Littauerjevi pokažeta, kako naj bi se najbolje odzvali na reakcijo prijateljev in sodelavcev. Vam ni jasno, zakaj je vaš partner užaljen? Se sprašujete, zakaj se je kolegica tako \"cudno\" oblekla? Vas zanima, koga postaviti na novo delovno mesto? Kakšne oglase napisati za razlicne tipe ljudi? Komu zaupati rutinsko delo? Kdo bo bolje opravil kreativni del naloge? Kako to, da je sodelavec nervozen, ceprav rok za izvedbo projekta potece šele cez en mesec? To je le nekaj vprašanj, na katere boste v knjigi našli številne koristne odgovore", BookIndex = 2600 });
            Add(new() { Id = new Guid("a50e2b66-93b3-4a7c-9642-52bfe9959a7e"), Name = "Cudež motivacije", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "Je pot...\r\nSo cilji...\r\nSo želje...\r\n\r\nZakaj je motivacija cudež?\r\n\r\nKer z njo uspete...\r\nKer z njo premagate težave...\r\nKer z njo dosežete vaše življenjske cilje...", BookIndex = 2700 });
            Add(new() { Id = new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), Name = "9 laži, zaradi katerih vaš posel ne uspeva, kot bi lahko... in resnica, ki ga bo osvobodila", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Chandler in Beckford razgaljata devet najpogostejših (in ponavadi usodnih) poslovnih mitov in ponujata preproste in navdihujoce rešitve za težave, ki si jih samostojni podjetniki ter lastniki majhnih podjetij povzrocajo iz dneva v dan. Presenetljive resnice, ki predstavljajo protistrup tem lažem, so Sam Beckford in vec sto njegovih strank, uspešnih samostojnih podjetnikov ter lastnikov majhnih podjetij, sami preizkusili\r\n\r\nTo sveže, živahno \"sveto pismo za poslovneže\" vam bo razkrilo, kaj in kako morate poceti, da bi vaš posel postal dobickonosen. V knjigi boste  odkrili tudi sestavino, ki v mnogih \"prakticnih\" poslovnih prirocnikih manjka - kako se iz dneva v dan motivirati, da bi te stvari dejansko lahko poceli", BookIndex = 2800 });
            Add(new() { Id = new Guid("1ad5e814-119c-4323-a613-87e99873e67f"), Name = "V odvisnosti od službe", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Namesto da išcete službo, zacnite iskati priložnosti", BookIndex = 2900 });
            Add(new() { Id = new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"), Name = "Sprožilci", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "30 prodajnih orodij, s katerimi lahko nadzorujete misli vaše stranke, jo motivirate, vplivate nanjo in jo prepricate v nakup.", BookIndex = 3000 });
            Add(new() { Id = new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"), Name = "Cena priložnosti", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Razmerje med ceno in dobickom in kaj to pomeni za vaše podjetje", BookIndex = 3100 });
            Add(new() { Id = new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"), Name = "Prodajajte odgovorno", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Kako hitro in manj stresno zaslužiti vec", BookIndex = 3200 });
            Add(new() { Id = new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"), Name = "Zmagovalni odnos", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Pot do vašega osebnega uspeha", BookIndex = 3300 });
            Add(new() { Id = new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), Name = "Zmagovalci", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Kako posameznike povezati v uspešen tim!", BookIndex = 3400 });
            Add(new() { Id = new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"), Name = "Brez tveganja ni uspeha", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Uspeha ne bo, ce boste nanj cakali. Knjiga vam bo razkrila, kaj morate storiti, da bi se zgodila prave stvari.", BookIndex = 3500 });
            Add(new() { Id = new Guid("a770ffb6-a764-446b-b9ff-6cd966c92147"), Name = "Surrounded by Setbacks", GenreID = new Guid("9456A8FF-2722-4CE6-A67A-91C9CFCD60FC"), Active = true, Description = "How to handle everything (and everyone) around you when all hell breaks loose, from the international bestselling author of Surrounded by Idiots . Not everything goes the way we want it to - the world or people around us sometimes just spin out of control. Just consider the Covid pandemic for starters. Or how about that mad neighbour you have living next-door to you? Or when work seems to be going down the toilet when the competition keep outsmarting you? So how do you handle everything life throws your way when you'd really prefer to tell everyone to get stuffed?Thomas Erikson will help you turn adversity into success with the help of the behavioural model made famous in Surrounded by Idiots . Starting by reminding us that life is as it is, Erikson helps you see that it is in fact useless to try to control everything happening around you. Instead of protesting when life throws you curveballs, focus instead on how to handle them. Just as you keep the weeds away from the garden to provide space and amazing flowers, you need to find an approach to adversity that works for you and will give you the chance to turn everything into success. Surrounded by Setbacks will help you pinpoint the approach that works for you and will entertain and empower you in equal measure.", BookIndex = 3600 });
            Add(new() { Id = new Guid("96856727-b094-4e6f-941c-d15bf44d766f"), Name = "Key Management Development Models Travel", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "'A very practical, engaging guide to the essential tools which managers at all levels need to be effective themselves and to develop others. Highly recommended.' Stuart Chambers, former CEO of Pilkington plc       Key Management Development Models gives you, at a glance, instant access to a full range of the best models available for developing your management skills and helping others to work and perform at their peak.       For anyone seeking to develop their management skills it can be hard to know where to begin. Key Management Development Models explains the tools in detail - what they are and when and how to use them, with key practical tips. It's like having your very own management development coach on hand explaining all the tools that you will ever need to know. EXPERT GUIDANCE FOR YOUR MANAGEMENT CAREER", BookIndex = 3700 });
            Add(new() { Id = new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), Name = "Skrivnost", GenreID = new Guid("F3C5B486-D668-4A48-9EC0-66804E40CC0A"), Active = true, Description = "Kaj vedo in pocnejo odlicni vodje\r\n\r\nV knjigi boste izvedeli:\r\n- kaj morate narediti, da boste resnicno navdihnili in motivirali druge ljudi\r\n- zakaj dobre vodje skrbi prihodnost\r\n- katera tri podrocja zahtevajo stalne izboljšave\r\n- kako lahko znatno okrepite svojo vodstveno kredibilnost - ali pa jo nezavedno unicite\r\n- kateri dve komponenti sta bistveni za resnicen uspeh in vodenje - in še veliko vec.", BookIndex = 3800 });
        }
    }
}

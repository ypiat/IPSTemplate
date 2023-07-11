
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Net.NetworkInformation;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEAuthorSeed : List<TEAuthor>
    {
        public TEAuthorSeed()
        {
            Add(new() { Id = new Guid("4bd02036-6a0f-4526-9a3d-ac479296e4c8"), FirstName = "Chris", LastName = "Barez-Brown", Active = true });
            Add(new() { Id = new Guid("6dd90191-35f9-4bb6-9a6e-48d3875caa9f"), FirstName = "David",  LastName = "Cotton", Active = true });
            Add(new() { Id = new Guid("d35d1b53-cd0e-4b42-9819-98e21fa6d2af"), FirstName = "Robert C.",  LastName = "Martin", Active = true });
            Add(new() { Id = new Guid("cb20cbcd-d000-4842-95f9-7a13fdedc908"), FirstName = "Brian",  LastName = "Tracy", Active = true });
            Add(new() { Id = new Guid("9847031e-413b-4641-8e30-542996ec4483"), FirstName = "John C.",  LastName = "Maxwell", Active = true });
            Add(new() { Id = new Guid("5bf8e384-ad9d-4382-b984-7cb6762135b7"), FirstName = "Charles C.", LastName = "Manz", Active = true });
            Add(new() { Id = new Guid("43110a64-ff40-4c5b-941f-ba5459e08ff6"), FirstName = "Kare",  LastName = "Anderson", Active = true });
            Add(new() { Id = new Guid("ed071b6f-4d39-45f5-b656-879c8d1cd4be"), FirstName = "dr. Dennis E.",   LastName = "Hensley", Active = true });
            Add(new() { Id = new Guid("8c52345c-b12c-476d-8457-e7a413ee0c85"), FirstName = "Beverly", LastName = "Sallee", Active = true });
            Add(new() { Id = new Guid("de0034e8-61f6-4cfb-bb00-550e18e35813"), FirstName = "Vince", LastName = "Poscente", Active = true });
            Add(new() { Id = new Guid("1e854d42-5abc-4cb8-8612-3604f1d6338f"), FirstName = "Maxwell", LastName = "Maltz", Active = true });
            Add(new() { Id = new Guid("a3b46595-20c6-456b-9a58-6137f8974ed9"), FirstName = "Skip ", LastName = " Ross", Active = true });
            Add(new() { Id = new Guid("6befae2b-6824-4da0-adc1-eb8c5a11e5ae"), FirstName = "Carole C. ", LastName = "Carlson", Active = true });
            Add(new() { Id = new Guid("3e0e45b6-f023-4f67-8a5e-73e94eb6f873"), FirstName = "Mamie ", LastName = " McCallough", Active = true });
            Add(new() { Id = new Guid("3e1d4bd1-a459-4f34-9b44-f6df55f8d981"), FirstName = "Lothar J.", LastName = " Seiwert", Active = true });
            Add(new() { Id = new Guid("ae11c234-4cd2-4e62-a21a-1eb31d250fb3"), FirstName = "Ann ", LastName = " McGee-Cooper", Active = true });
            Add(new() { Id = new Guid("668b0be2-e639-409e-a37c-efd37cb9baa5"), FirstName = "Prof.Ben C. ", LastName = " Fletcher", Active = true });
            Add(new() { Id = new Guid("1d0bff2e-770e-4879-9ed5-ef86122b139d"), FirstName = "dr. Karen ", LastName = " Pine", Active = true });
            Add(new() { Id = new Guid("f562de09-54ff-4819-b154-bb7e753109a0"), FirstName = "dr. Danny", LastName = " Penman", Active = true });
            Add(new() { Id = new Guid("2f644084-5a69-43cb-9ca5-23394463baf7"), FirstName = "Jim", LastName = " Clemmer", Active = true });
            Add(new() { Id = new Guid("64b8e52e-0365-47e2-805c-a173583b847b"), FirstName = "Simona", LastName = " Sternad Zabukovšek", Active = true });
            Add(new() { Id = new Guid("fd68b897-49ff-43a8-9ff8-4d2bdef78f91"), FirstName = "Polona", LastName = " Tominc", Active = true });
            Add(new() { Id = new Guid("7ea4a0e0-9b31-4ad7-b245-6fc340ddfe2e"), FirstName = "Tjaša", LastName = " Štrukelj", Active = true });
            Add(new() { Id = new Guid("880d61ba-fd72-42fe-a96e-83093461228c"), FirstName = "Samo", LastName = " Bobek", Active = true });
            Add(new() { Id = new Guid("8908c397-5f49-454b-83c8-5b6d93bacab8"), FirstName = "Dr.Marilee", LastName = " Adams", Active = true });
            Add(new() { Id = new Guid("1c828dbc-f44b-41c8-b29e-1412d0fcb749"), FirstName = "Benjamin", LastName = " Levy", Active = true });
            Add(new() { Id = new Guid("b69672d6-5c2c-4f60-b0e7-12d8a763e4b4"), FirstName = "Travis", LastName = " Bradberry", Active = true });
            Add(new() { Id = new Guid("6be06e09-e930-490a-9382-11ef9785e516"), FirstName = "Jean", LastName = " Greaves", Active = true });
            Add(new() { Id = new Guid("22ec1668-ef8e-4c98-afcf-92c3703d278c"), FirstName = "Allan", LastName = " Pease", Active = true });
            Add(new() { Id = new Guid("5ce3747a-ab03-49b8-8282-17c73bafd79b"), FirstName = "Barbara", LastName = " Pease", Active = true });
            Add(new() { Id = new Guid("377329f3-1449-44ec-96ed-963991ae4144"), FirstName = "dr.Bill", LastName = " Quain", Active = true });
            Add(new() { Id = new Guid("2d2e421b-4148-4a1d-8635-ee84c339c74e"), FirstName = "Pat", LastName = " Mesiti", Active = true });
            Add(new() { Id = new Guid("497a44de-28f3-40ed-b3b2-0352bbf537f3"), FirstName = "Pat", LastName = " Riley", Active = true });
            Add(new() { Id = new Guid("b102a246-c9d0-4124-8dd5-63792e079d6c"), FirstName = "Florence", LastName = " Littauer", Active = true });
            Add(new() { Id = new Guid("34f6ed97-96f7-44df-a576-5a0e0f22fb7b"), FirstName = "Marita", LastName = " Littauer", Active = true });
            Add(new() { Id = new Guid("5a8fa816-1db3-4281-9575-eb16a6b1b85a"), FirstName = "George", LastName = " Shinn", Active = true });
            Add(new() { Id = new Guid("c583f679-ee3f-4b8d-899c-4fc4ba9473ed"), FirstName = "Mark", LastName = " Miller", Active = true });
            Add(new() { Id = new Guid("03f05554-2fa6-4f05-9b1f-07b1e93dc815"), FirstName = "Steve", LastName = " Chandler", Active = true });
            Add(new() { Id = new Guid("84cb355b-9f39-4afd-8176-3db1fcbd9e26"), FirstName = "Sam", LastName = " Beckford", Active = true });
            Add(new() { Id = new Guid("679cff41-cbd8-4a24-b245-be846df6d70b"), FirstName = "Burke", LastName = " Hedges", Active = true });
            Add(new() { Id = new Guid("72f8409a-310f-4dd4-8997-13c290f9450b"), FirstName = "Joseph", LastName = " Sugarman", Active = true });
            Add(new() { Id = new Guid("9937be0c-d710-42e1-84d4-08a51417d67b"), FirstName = "Todd", LastName = " Duncan", Active = true });
            Add(new() { Id = new Guid("cf9c8d7d-b7ba-4cca-996f-67c06710af99"), FirstName = "Ken", LastName = " Blanchard", Active = true });
            Add(new() { Id = new Guid("718c2ca7-97ae-4059-9ed2-faa12a0f1eb8"), FirstName = "Sheldon", LastName = " Bowles", Active = true });
            Add(new() { Id = new Guid("a4c01ce6-a52e-4c4a-86be-726cf0798b87"), FirstName = "Roger", LastName = " Fritz", Active = true });
            Add(new() { Id = new Guid("2e3b2c42-9dc6-4149-8dcc-a8c6851f7aca"), FirstName = "Janez", LastName = "Mayer", Active = true });
            Add(new() { Id = new Guid("c2211dbf-f130-4f08-b39a-665f57e21dad"), FirstName = "Janez", LastName = "Bečaj", Active = true });
            Add(new() { Id = new Guid("4c8ce6ab-e80f-4681-b323-97b79ed7dafa"), FirstName = "Ana Nuša", LastName = "Kneževič", Active = true });
            Add(new() { Id = new Guid("31afe055-c651-4730-83a4-ee6a75f3a1a3"), FirstName = "Manca", LastName = "Košir", Active = true });
            Add(new() { Id = new Guid("948d913e-1c66-4fe9-a3b7-42f02366c181"), FirstName = "Bogomir", LastName = "Kovač", Active = true });
            Add(new() { Id = new Guid("182f5aff-bdef-4c83-9951-5acb08ce766c"), FirstName = "Lea", LastName = "Pisani", Active = true });
            Add(new() { Id = new Guid("549a7a20-ca4c-4563-9ff1-2474c7bd878d"), FirstName = "Peter", LastName = "Praper", Active = true });
            Add(new() { Id = new Guid("c30a5a61-f324-4c35-9ad6-d8fa7a104be6"), FirstName = "Vladislav", LastName = "Rajkovič", Active = true });
            Add(new() { Id = new Guid("6a574ece-95e2-4a40-bc52-9ed5899bb0aa"), FirstName = "Anton", LastName = "Trstenjak", Active = true });
            Add(new() { Id = new Guid("dd378ba2-ed55-44fc-b299-c58292b62f07"), FirstName = "Marija", LastName = "Velikonja", Active = true });
            Add(new() { Id = new Guid("bb9b5013-d721-4c09-a86b-eb30e51d3527"), FirstName = "Thomas", LastName = "Erikson", Active = true });
        }
    }
}

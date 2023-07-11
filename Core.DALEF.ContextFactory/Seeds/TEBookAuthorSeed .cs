
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Net;
using System.Net.NetworkInformation;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEBookAuthorSeed : List<TEBookAuthor>
    {
        public TEBookAuthorSeed()
        {
            Add(new() { Id = new Guid("b6e02c6d-9189-437d-bb26-f5e9f9c69e0a"), AuthorID = new Guid("4BD02036-6A0F-4526-9A3D-AC479296E4C8"), BookID = new Guid("9a27d8d9-b415-489b-bd35-dc1730200dbf"), Active = true });
            Add(new() { Id = new Guid("2449684e-5d21-4282-93e9-f5c6e958390a"), AuthorID = new Guid("D35D1B53-CD0E-4B42-9819-98E21FA6D2AF"), BookID = new Guid("febca16c-9fce-4d75-b7d1-177bfa143db1"), Active = true });
            Add(new() { Id = new Guid("607fbdd3-696c-4b0b-a455-374764a4e1cd"), AuthorID = new Guid("CB20CBCD-D000-4842-95F9-7A13FDEDC908"), BookID = new Guid("3678e8e4-7716-42ae-98a2-277adab4bccc"), Active = true });
            Add(new() { Id = new Guid("c0ce42ad-dc7a-43bd-a01f-f96f3729aee4"), AuthorID = new Guid("9847031E-413B-4641-8E30-542996EC4483"), BookID = new Guid("c5fa5dfb-44a3-4ddb-90c6-2f9617221bdd"), Active = true });
            Add(new() { Id = new Guid("7a8d3e54-2726-4cc7-8767-beea88f65ced"), AuthorID = new Guid("5BF8E384-AD9D-4382-B984-7CB6762135B7"), BookID = new Guid("8feb709d-b1e1-40e6-9b47-c4b8d9d23412"), Active = true });
            Add(new() { Id = new Guid("4e03e3c0-ee85-45af-abd3-a1a10d1661f1"), AuthorID = new Guid("43110A64-FF40-4C5B-941F-BA5459E08FF6"), BookID = new Guid("e4f1011a-d6b3-4d12-908d-9ba618a3f3ab"), Active = true });
            Add(new() { Id = new Guid("da7da3d2-05dd-4c83-88be-f32968d34c54"), AuthorID = new Guid("2e3b2c42-9dc6-4149-8dcc-a8c6851f7aca"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("7543912d-6e5d-4ea4-82e1-65b8be3a1db4"), AuthorID = new Guid("c2211dbf-f130-4f08-b39a-665f57e21dad"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("97f4ef0b-f9e3-4fc5-89bc-fc08b2260052"), AuthorID = new Guid("4c8ce6ab-e80f-4681-b323-97b79ed7dafa"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("be288432-bf6b-454a-89e3-aa57c6533726"), AuthorID = new Guid("31afe055-c651-4730-83a4-ee6a75f3a1a3"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("5a9d216f-6a91-4407-9c53-f93432095195"), AuthorID = new Guid("948d913e-1c66-4fe9-a3b7-42f02366c181"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("945e0b04-0d13-49b6-830d-c3320abafc03"), AuthorID = new Guid("182f5aff-bdef-4c83-9951-5acb08ce766c"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("85f41ba7-472a-4264-bea1-e116f832242d"), AuthorID = new Guid("549a7a20-ca4c-4563-9ff1-2474c7bd878d"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("fcfe9fcb-85eb-492c-9a7b-5a6b49ecdc09"), AuthorID = new Guid("c30a5a61-f324-4c35-9ad6-d8fa7a104be6"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("80aabbf4-e3a5-4ed9-a605-508aadb3f2c6"), AuthorID = new Guid("6a574ece-95e2-4a40-bc52-9ed5899bb0aa"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("be9f0787-b10d-4162-853b-b0c34369e1e5"), AuthorID = new Guid("dd378ba2-ed55-44fc-b299-c58292b62f07"), BookID = new Guid("d8c6cf0d-16b7-4197-bd3b-70faf2341b6e"), Active = true });
            Add(new() { Id = new Guid("249cf113-a86b-471c-ae0d-ac3571fa6958"), AuthorID = new Guid("ED071B6F-4D39-45F5-B656-879C8D1CD4BE"), BookID = new Guid("a4c539aa-ad89-437c-8767-ff5bebaf83a7"), Active = true });
            Add(new() { Id = new Guid("49932271-24a2-4585-bd23-4e898a2060c8"), AuthorID = new Guid("8C52345C-B12C-476D-8457-E7A413EE0C85"), BookID = new Guid("a2d96655-ab60-46cb-af2b-d31144f6b91d"), Active = true });
            Add(new() { Id = new Guid("e7b04c2e-8eef-4e17-b2ca-d39468c6df5c"), AuthorID = new Guid("DE0034E8-61F6-4CFB-BB00-550E18E35813"), BookID = new Guid("081bc263-1bfb-4c65-aeb5-5725bc134903"), Active = true });
            Add(new() { Id = new Guid("e3e34dd2-e8a1-422f-bf0e-e4c85bf11f17"), AuthorID = new Guid("1E854D42-5ABC-4CB8-8612-3604F1D6338F"), BookID = new Guid("aa849042-ecd7-476d-b296-610c83240ad0"), Active = true });
            Add(new() { Id = new Guid("f2b98c3c-401f-49f1-8551-8165b8b88d43"), AuthorID = new Guid("A3B46595-20C6-456B-9A58-6137F8974ED9"), BookID = new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), Active = true });
            Add(new() { Id = new Guid("b32c770a-493a-44bc-8478-6c68e701b945"), AuthorID = new Guid("6BEFAE2B-6824-4DA0-ADC1-EB8C5A11E5AE"), BookID = new Guid("868852d4-8bb6-473e-963f-3d2588e3c068"), Active = true });
            Add(new() { Id = new Guid("72f8eafb-76b3-4278-88bf-4ee466b94733"), AuthorID = new Guid("3E0E45B6-F023-4F67-8A5E-73E94EB6F873"), BookID = new Guid("e3553e15-459c-4585-9790-00421af356e1"), Active = true });
            Add(new() { Id = new Guid("734c10ec-a1f6-4b5d-b396-4a0a35dcd4ef"), AuthorID = new Guid("3E1D4BD1-A459-4F34-9B44-F6DF55F8D981"), BookID = new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), Active = true });
            Add(new() { Id = new Guid("15952e40-d30d-4d36-8c4b-14b9d1b7c05e"), AuthorID = new Guid("AE11C234-4CD2-4E62-A21A-1EB31D250FB3"), BookID = new Guid("7a042797-0838-4b93-8779-51e4364d3cc4"), Active = true });
            Add(new() { Id = new Guid("0cc4f451-88ff-41a2-b633-c3ffe3a4a430"), AuthorID = new Guid("668B0BE2-E639-409E-A37C-EFD37CB9BAA5"), BookID = new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), Active = true });
            Add(new() { Id = new Guid("9caff905-8864-43c7-a54a-28af62d3d360"), AuthorID = new Guid("1D0BFF2E-770E-4879-9ED5-EF86122B139D"), BookID = new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), Active = true });
            Add(new() { Id = new Guid("33a568c3-ca11-44e5-8355-412b81482f88"), AuthorID = new Guid("F562DE09-54FF-4819-B154-BB7E753109A0"), BookID = new Guid("c6686738-c897-4e32-9c3f-7e0ac9d25f64"), Active = true });
            Add(new() { Id = new Guid("75f8e734-5cf8-4701-a5dc-890e9be1e2e1"), AuthorID = new Guid("9847031E-413B-4641-8E30-542996EC4483"), BookID = new Guid("f11b616b-51c9-47bd-9d82-794b056781f4"), Active = true });
            Add(new() { Id = new Guid("fe6a7442-6a65-43df-a108-4168d85a30c9"), AuthorID = new Guid("2F644084-5A69-43CB-9CA5-23394463BAF7"), BookID = new Guid("1bdbc2a2-488a-412e-b047-82de20caab26"), Active = true });
            Add(new() { Id = new Guid("82df1422-1585-4122-a408-5492eb3b3cfb"), AuthorID = new Guid("64B8E52E-0365-47E2-805C-A173583B847B"), BookID = new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), Active = true });
            Add(new() { Id = new Guid("af6332cb-eb4e-4329-8f77-0ce2775ff862"), AuthorID = new Guid("FD68B897-49FF-43A8-9FF8-4D2BDEF78F91"), BookID = new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), Active = true });
            Add(new() { Id = new Guid("dd0640f1-b375-4838-9872-e27577a9c9eb"), AuthorID = new Guid("7EA4A0E0-9B31-4AD7-B245-6FC340DDFE2E"), BookID = new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), Active = true });
            Add(new() { Id = new Guid("35fb169b-9a10-43ad-89de-971bb8efb221"), AuthorID = new Guid("880D61BA-FD72-42FE-A96E-83093461228C"), BookID = new Guid("1c4445be-66eb-4f6c-9c29-511247ddeacf"), Active = true });
            Add(new() { Id = new Guid("3a8644fd-ea0a-4438-b351-fa7a3f3963ac"), AuthorID = new Guid("8908C397-5F49-454B-83C8-5B6D93BACAB8"), BookID = new Guid("85f2bbf0-ab49-4153-beb9-226af992767b"), Active = true });
            Add(new() { Id = new Guid("ba3e9b26-6914-4028-bcec-183414569afd"), AuthorID = new Guid("1C828DBC-F44B-41C8-B29E-1412D0FCB749"), BookID = new Guid("d14ba13b-e446-422a-a6cb-cbe0ef355d0b"), Active = true });
            Add(new() { Id = new Guid("292442a8-a4bf-423f-a4bc-0db0c6589211"), AuthorID = new Guid("B69672D6-5C2C-4F60-B0E7-12D8A763E4B4"), BookID = new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), Active = true });
            Add(new() { Id = new Guid("ce885dea-1a97-401f-ba68-c5b9e9ce8ba4"), AuthorID = new Guid("6BE06E09-E930-490A-9382-11EF9785E516"), BookID = new Guid("cd461206-e127-4b46-931f-f448623ea7b0"), Active = true });
            Add(new() { Id = new Guid("a586d61d-e700-4a51-b28a-b106a3e1cebd"), AuthorID = new Guid("22EC1668-EF8E-4C98-AFCF-92C3703D278C"), BookID = new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), Active = true });
            Add(new() { Id = new Guid("e5a1b46f-d984-46a2-bb23-6212bcacd1a7"), AuthorID = new Guid("5CE3747A-AB03-49B8-8282-17C73BAFD79B"), BookID = new Guid("c676c6ba-a951-426c-bd8e-503609aecbe3"), Active = true });
            Add(new() { Id = new Guid("247572d0-d5e9-4124-9819-e600d49a4ced"), AuthorID = new Guid("377329F3-1449-44EC-96ED-963991AE4144"), BookID = new Guid("b6acf3f2-affc-4429-9232-5cc4e950f2da"), Active = true });
            Add(new() { Id = new Guid("716fff56-4a87-47f5-9782-f31e0c975abc"), AuthorID = new Guid("2D2E421B-4148-4A1D-8635-EE84C339C74E"), BookID = new Guid("c05bc45d-013a-497a-83f5-1ca7418f1011"), Active = true });
            Add(new() { Id = new Guid("02481a61-07f9-45c5-8809-c0bdab00320e"), AuthorID = new Guid("497A44DE-28F3-40ED-B3B2-0352BBF537F3"), BookID = new Guid("ff9354d2-ace1-4de9-8cf9-42d204a50923"), Active = true });
            Add(new() { Id = new Guid("e5da9281-9e15-4607-92cc-d4150148fc33"), AuthorID = new Guid("B102A246-C9D0-4124-8DD5-63792E079D6C"), BookID = new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), Active = true });
            Add(new() { Id = new Guid("d9e83449-e3dc-4f45-9ec2-e1d61fb1d351"), AuthorID = new Guid("34F6ED97-96F7-44DF-A576-5A0E0F22FB7B"), BookID = new Guid("86eee0ac-d137-49ef-827d-3e44d61c5a64"), Active = true });
            Add(new() { Id = new Guid("f51bb25b-8a9c-4df8-8619-e0f1ab774888"), AuthorID = new Guid("5A8FA816-1DB3-4281-9575-EB16A6B1B85A"), BookID = new Guid("a50e2b66-93b3-4a7c-9642-52bfe9959a7e"), Active = true });
            Add(new() { Id = new Guid("28c54b4c-bb56-4216-9025-9663de59878e"), AuthorID = new Guid("03F05554-2FA6-4F05-9B1F-07B1E93DC815"), BookID = new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), Active = true });
            Add(new() { Id = new Guid("244b6ff8-5062-41e0-8960-1dcf35e798da"), AuthorID = new Guid("84CB355B-9F39-4AFD-8176-3DB1FCBD9E26"), BookID = new Guid("4acd1fab-00d4-4d57-9ab8-978bb6eb07ac"), Active = true });
            Add(new() { Id = new Guid("a929b517-fdfa-4fb7-9997-86800d24f935"), AuthorID = new Guid("679CFF41-CBD8-4A24-B245-BE846DF6D70B"), BookID = new Guid("1ad5e814-119c-4323-a613-87e99873e67f"), Active = true });
            Add(new() { Id = new Guid("acf38050-760b-4a50-87aa-7afd31b86626"), AuthorID = new Guid("72F8409A-310F-4DD4-8997-13C290F9450B"), BookID = new Guid("54e2f7dc-0de3-4afa-9266-28638a0738c1"), Active = true });
            Add(new() { Id = new Guid("72d278c4-5890-411d-8799-0bf8e20da219"), AuthorID = new Guid("377329F3-1449-44EC-96ED-963991AE4144"), BookID = new Guid("5d9ccdeb-153e-4c8b-ba53-67cb2299c689"), Active = true });
            Add(new() { Id = new Guid("9154fec5-404f-4958-916b-4ff9314eaae6"), AuthorID = new Guid("9937BE0C-D710-42E1-84D4-08A51417D67B"), BookID = new Guid("09c427f8-e752-4754-a3a2-7318ee63564b"), Active = true });
            Add(new() { Id = new Guid("b9dad31a-2b1a-4d70-9ec7-14f7449f9c7d"), AuthorID = new Guid("9847031E-413B-4641-8E30-542996EC4483"), BookID = new Guid("beafa43f-5215-4f51-91e8-5d6c0aca2dad"), Active = true });
            Add(new() { Id = new Guid("69d747c0-8943-4dc8-ae50-219a839b65bd"), AuthorID = new Guid("CF9C8D7D-B7BA-4CCA-996F-67C06710AF99"), BookID = new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), Active = true });
            Add(new() { Id = new Guid("9f3ec7b9-b031-4940-b647-42ba4f5cd311"), AuthorID = new Guid("718C2CA7-97AE-4059-9ED2-FAA12A0F1EB8"), BookID = new Guid("640a6b5a-feea-4312-9d87-567fd465adf1"), Active = true });
            Add(new() { Id = new Guid("d277cc9a-6ba0-45d3-9eed-2476edbe1f7a"), AuthorID = new Guid("A4C01CE6-A52E-4C4A-86BE-726CF0798B87"), BookID = new Guid("4fe5155b-a047-4a08-b7d9-baf24ea6a581"), Active = true });
            Add(new() { Id = new Guid("823ef286-ffb7-4457-83f9-ca48b22100af"), AuthorID = new Guid("bb9b5013-d721-4c09-a86b-eb30e51d3527"), BookID = new Guid("a770ffb6-a764-446b-b9ff-6cd966c92147"), Active = true });
            Add(new() { Id = new Guid("4041d5e3-d128-4933-a87c-fe22012f91f9"), AuthorID = new Guid("6DD90191-35F9-4BB6-9A6E-48D3875CAA9F"), BookID = new Guid("96856727-b094-4e6f-941c-d15bf44d766f"), Active = true });
            Add(new() { Id = new Guid("cee18031-d948-4bc6-87ff-81806181c44f"), AuthorID = new Guid("CF9C8D7D-B7BA-4CCA-996F-67C06710AF99"), BookID = new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), Active = true });
            Add(new() { Id = new Guid("e7befff7-dc99-4a9d-b60c-17e9696c5c7a"), AuthorID = new Guid("C583F679-EE3F-4B8D-899C-4FC4BA9473ED"), BookID = new Guid("9527dea2-51f6-44d9-a681-8bc846b9c557"), Active = true });
        }
    }
}

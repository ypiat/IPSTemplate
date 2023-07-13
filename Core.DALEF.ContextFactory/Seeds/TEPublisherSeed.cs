
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEPublisherSeed : List<TEPublisher>
    {
        public TEPublisherSeed()
        {
            Add(new() { Id = new Guid("1f855264-06ea-45d1-a83d-75ace379a617"), Name = "Penguin UK", Active = true });
            Add(new() { Id = new Guid("e5122ef3-0fe3-41bc-9d9d-b2bad13b8e94"), Name = "Pearson Education, Limited", Active = true });
            Add(new() { Id = new Guid("920ff788-b598-4f89-aa66-beeec3c0e64e"), Name = "Prentice Hall", Active = true });
            Add(new() { Id = new Guid("d6c559d6-373d-4a53-9a46-f5635a4e42f9"), Name = "Založba Tuma", Active = true });
            Add(new() { Id = new Guid("12ba737b-48c7-4899-b1a5-68f18c3a9abb"), Name = "Lisac &Licac", Active = true });
            Add(new() { Id = new Guid("cefca4d5-e247-4330-acd2-69969285c0a8"), Name = "Amalietti & Amalietti", Active = true });
            Add(new() { Id = new Guid("0dc2f9fc-33ca-4bb4-a700-a84333ffdafd"), Name = "Lifetrek ", Active = true });
            Add(new() { Id = new Guid("06d30621-b28d-4dd9-8df3-81f697bbbfe4"), Name = "Orbis ", Active = true });
            Add(new() { Id = new Guid("afde255d-88bc-4cdc-af97-c0f57ec73b62"), Name = "Založba Amalietti, d.o.o.", Active = true });
            Add(new() { Id = new Guid("9a9a0836-c01f-461d-a361-15b3244af1e5"), Name = "Dedalus ", Active = true });
            Add(new() { Id = new Guid("a62f0491-8dc0-44f9-9f04-d317a522e154"), Name = "TwentyOne Network & Amalietti d.o.o.", Active = true });
            Add(new() { Id = new Guid("948745ee-a8b2-4493-9989-9556620e8dc7"), Name = "Časnik Finance, d.o.o ", Active = true });
            Add(new() { Id = new Guid("bb474f93-4f17-456d-994c-6a89d542ff62"), Name = "Financial Times ", Active = true });
            Add(new() { Id = new Guid("4119a4e3-0d37-44e3-8bf4-6674f9964c7d"), Name = "Simon &Schuster ", Active = true });
            Add(new() { Id = new Guid("052833ef-ce44-4097-941a-302d21a3e3bb"), Name = "Bedenik Media d.o.o ", Active = true });
            Add(new() { Id = new Guid("5725e6c6-5102-4eef-ac96-4f8245f581a9"), Name = "GV Založba, d.o.o ", Active = true });
            Add(new() { Id = new Guid("b4350dd3-5850-461e-b91c-43167e657312"), Name = "Portfolio", Active = true });
            Add(new() { Id = new Guid("f9da53f1-6b24-4d3e-b4c8-a39ec264f405"), Name = "Crown Publishing Group ", Active = true });
            Add(new() { Id = new Guid("36b9ad0c-2bc9-40c7-9f83-6187fc76cbfd"), Name = "The Dryden Press ", Active = true });
            Add(new() { Id = new Guid("cf8e0ecb-330f-4f21-9737-05c28396d3c5"), Name = "Katarina Zrinski ", Active = true });
            Add(new() { Id = new Guid("3e34d509-cfc8-4a36-b7a7-fcd38e3b1c37"), Name = "Samožaložba SABB ", Active = true });
            Add(new() { Id = new Guid("b668a744-31f0-49d7-9547-a21830398a5b"), Name = "Samožaložba Metka Feher Pal ", Active = true });
            Add(new() { Id = new Guid("47000d6e-2200-4b94-a2e7-1521be3aecef"), Name = "Creatoor ", Active = true });
            Add(new() { Id = new Guid("fe270392-7b99-459b-8cdf-77f0cccad02e"), Name = "Katzengruber ", Active = true });
            Add(new() { Id = new Guid("4371eec1-3303-40da-9b88-ee4ce07810e4"), Name = "Slovensko združevanje za kakovost in odličnost ", Active = true });
            Add(new() { Id = new Guid("bd68b365-7014-4b4b-9feb-15cfedc63b6c"), Name = "Korotan ", Active = true });
            Add(new() { Id = new Guid("bcff7aec-f9b2-4cad-afae-5abfe7e57752"), Name = "University of North Texas", Active = true });
            Add(new() { Id = new Guid("27979172-3cfe-4167-950f-b96b9f2ff157"), Name = "Packt Publishing ", Active = true });
            Add(new() { Id = new Guid("1e9f7f17-65dd-41ff-9b2a-a1466c0a08a9"), Name = "Založba Forum Media d.o.o.", Active = true });
        }
    }
}


using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Net.NetworkInformation;

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
        }
    }
}

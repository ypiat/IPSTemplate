
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Net.NetworkInformation;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEGenreSeed : List<TEGenre>
    {
        public TEGenreSeed()
        {
            Add(new() { Id = new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), Name = "IT", Active = true });
        }
    }
}

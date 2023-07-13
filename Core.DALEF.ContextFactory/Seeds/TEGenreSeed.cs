
using IPSTemplate.Dal.Models;
using NetTopologySuite.Algorithm;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Core.DALEF.ContextFactory.Seeds
{
    public class TEGenreSeed : List<TEGenre>
    {
        public TEGenreSeed()
        {
            Add(new() { Id = new Guid("e74ec0d0-4f62-424a-a876-1ed6815e9de5"), Name = "Software/IT", Active = true, Color = "#007dc3" });
            Add(new() { Id = new Guid("9456a8ff-2722-4ce6-a67a-91c9cfcd60fc"), Name = " Osebna rast/Psihologija", Active = true, Color = "#19b698" });
            Add(new() { Id = new Guid("f3c5b486-d668-4a48-9ec0-66804e40cc0a"), Name = "Poslovna kultura", Active = true, Color = "#ea6153" });
            Add(new() { Id = new Guid("9147b105-9b2b-4d11-8f19-64d2a588cd44"), Name = "Strokovna monografija", Active = true, Color = "#adb5bd" });
            Add(new() { Id = new Guid("dad56ba5-640c-4ec1-accb-35463c824b12"), Name = "Biography/Experience", Active = true, Color = "#f16e3f" });
        }
    }
}

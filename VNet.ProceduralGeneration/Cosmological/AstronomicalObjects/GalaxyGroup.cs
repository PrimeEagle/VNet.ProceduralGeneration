using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class GalaxyGroup : AstronomicalObject
    {
        public ConcurrentBag<Galaxy> Galaxies { get; set; } = new ConcurrentBag<Galaxy>();
    }
}
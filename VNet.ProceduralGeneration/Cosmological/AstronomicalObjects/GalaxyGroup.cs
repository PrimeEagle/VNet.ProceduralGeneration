using System.Collections.Concurrent;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class GalaxyGroup : AstronomicalObject
    {
        public List<Galaxy> Galaxies { get; set; } = new List<Galaxy>();
    }
}
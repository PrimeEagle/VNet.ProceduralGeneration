using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base.Void;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;


public class BaryonicMatterVoid : Void
{
    public List<GalaxyGroup> GalaxyGroups { get; set; }
    public List<Galaxy> Galaxies { get; set; }
    public List<VoidGalaxy> VoidGalaxies { get; set; }
}
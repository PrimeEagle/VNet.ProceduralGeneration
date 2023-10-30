using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CollectionNeverQueried.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public class Universe : AstronomicalObjectGroup
{
    public Universe()
    {
        NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    public Universe(AstronomicalObject parent) : base(parent)
    {
        NonHierarchyObjects = new List<IAstronomicalObject>();
    }

    public int DimensionX { get; init; }
    public int DimensionY { get; init; }
    public int DimensionZ { get; init; }
    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }
    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }
    public CosmicWeb CosmicWeb { get; set; }
    public List<IAstronomicalObject> NonHierarchyObjects { get; init; }
    public float ΩBaryonicMatter => (float)BaryonicMatterPercent / 100.0f;
    public float ΩDarkMatter => (float)DarkMatterPercent / 100.0f;
    public float ΩDarkEnergy => (float)DarkEnergyPercent / 100.0f;
    public float ΩMatter => ΩBaryonicMatter + ΩDarkMatter;
    public float CosmicMicrowaveBackground { get; set; }
}

using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class CosmicWebContext : GroupContextBase
{
    public CosmicWebContext()
    {
    }

    public CosmicWebContext(Universe universe)
    {
        LoadBaseProperties(universe);
    }

    public int MapX { get; set; }
    public int MapY { get; set; }
    public int MapZ { get; set; }
    public double BaryonicMatterPercentage { get; set; }
    public double DarkMatterPercentage { get; set; }
    public double DarkEnergyPercentage { get; set; }
    public float CosmicMicrowaveBackground { get; set; }
    public double ExpansionRate { get; set; }
    public CurvatureType Curvature { get; set; }
    public int CountBaryonicMatterPercentageFactor { get; set; }
    public int CountDarkMatterPercentageFactor { get; set; }
    public int CountDarkEnergyPercentageFactor { get; set; }
}
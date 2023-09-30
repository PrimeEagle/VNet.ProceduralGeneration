using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class CosmicWebContext : BaseContext
{
    public double DarkEnergyPercent { get; set; }
    public double DarkMatterPercent { get; set; }
    public double BaryonicMatterPercent { get; set; }
    public CurvatureType Curvature { get; set; }
    public double ConnectivityFactor { get; set; }
    public bool CosmicInflationOccurred { get; set; }
    public bool CmbHasVariations { get; set; }
    public double ExpansionRate { get; set; }
    public double CosmicMicrowaveBackground { get; set; }
    public bool IsInInflationPhase { get; set; }


    public CosmicWebContext()
    {

    }

    public CosmicWebContext(Universe universe)
    {
        LoadBaseProperties((AstronomicalObject)universe);

        this.DarkEnergyPercent = universe.DarkEnergyPercent;
        this.DarkMatterPercent = universe.DarkMatterPercent;
        this.BaryonicMatterPercent = universe.BaryonicMatterPercent;
        this.Curvature = universe.Curvature;
        this.ConnectivityFactor = universe.ConnectivityFactor;
        this.CosmicInflationOccurred = universe.CosmicInflationOccurred;
        this.CmbHasVariations = universe.CmbHasVariations;
        this.ExpansionRate = universe.ExpansionRate;
        this.CosmicMicrowaveBackground = universe.CosmicMicrowaveBackground;
        this.IsInInflationPhase = universe.IsInInflationPhase;
    }
}
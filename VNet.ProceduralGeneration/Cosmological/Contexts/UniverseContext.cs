using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class UniverseContext : GroupContextBase
{
    public UniverseContext(GeneratorSettings settings)
    {
        MinDarkEnergyPercent = settings.Basic.MinDarkEnergyPercent;
        MaxDarkEnergyPercent = settings.Basic.MaxDarkEnergyPercent;
        MinDarkMatterPercent = settings.Basic.MinDarkMatterPercent;
        MaxDarkMatterPercent = settings.Basic.MaxDarkMatterPercent;
        MinBaryonicMatterPercent = settings.Basic.MinBaryonicMatterPercent;
        MaxBaryonicMatterPercent = settings.Basic.MaxBaryonicMatterPercent;
        MinUniverseAge = settings.Basic.MinUniverseAge;
        MaxUniverseAge = settings.Basic.MaxUniverseAge;
        MinConnectivityFactor = settings.Advanced.Universe.MinConnectivityFactor;
        MaxConnectivityFactor = settings.Advanced.Universe.MaxConnectivityFactor;
    }

    public double MinDarkEnergyPercent { get; set; }
    public double MaxDarkEnergyPercent { get; set; }
    public double MinDarkMatterPercent { get; set; }
    public double MaxDarkMatterPercent { get; set; }
    public double MinBaryonicMatterPercent { get; set; }
    public double MaxBaryonicMatterPercent { get; set; }
    public float MinUniverseAge { get; set; }
    public float MaxUniverseAge { get; set; }
    public double MinConnectivityFactor { get; set; }
    public double MaxConnectivityFactor { get; set; }
}
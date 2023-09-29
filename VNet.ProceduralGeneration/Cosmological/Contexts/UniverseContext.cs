using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class UniverseContext : BaseContext
    {
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


        public UniverseContext(GeneratorSettings settings)
        {
            this.MinDarkEnergyPercent = config.MinDarkEnergyPercent;
            this.MaxDarkEnergyPercent = config.MaxDarkEnergyPercent;
            this.MinDarkMatterPercent = config.MinDarkMatterPercent;
            this.MaxDarkMatterPercent = config.MaxDarkMatterPercent;
            this.MinBaryonicMatterPercent = config.MinBaryonicMatterPercent;
            this.MaxBaryonicMatterPercent = config.MaxBaryonicMatterPercent;
            this.MinUniverseAge = config.MinUniverseAge;
            this.MaxUniverseAge = config.MaxUniverseAge;
            this.MinConnectivityFactor = config.MinConnectivityFactor;
            this.MaxConnectivityFactor = config.MaxConnectivityFactor;
        }
    }
}
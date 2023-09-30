using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Contexts
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
            this.MinDarkEnergyPercent = settings.Basic.MinDarkEnergyPercent;
            this.MaxDarkEnergyPercent = settings.Basic.MaxDarkEnergyPercent;
            this.MinDarkMatterPercent = settings.Basic.MinDarkMatterPercent;
            this.MaxDarkMatterPercent = settings.Basic.MaxDarkMatterPercent;
            this.MinBaryonicMatterPercent = settings.Basic.MinBaryonicMatterPercent;
            this.MaxBaryonicMatterPercent = settings.Basic.MaxBaryonicMatterPercent;
            this.MinUniverseAge = settings.Basic.MinUniverseAge;
            this.MaxUniverseAge = settings.Basic.MaxUniverseAge;
            this.MinConnectivityFactor = settings.Advanced.MinConnectivityFactor;
            this.MaxConnectivityFactor = settings.Advanced.MaxConnectivityFactor;
        }
    }
}
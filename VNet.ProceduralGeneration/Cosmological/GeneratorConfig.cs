using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class GeneratorConfig
    {
        private const double DEFAULT_MIN_DARK_ENERGY_PERCENT = 65.0;
        private const double DEFAULT_MAX_DARK_ENERGY_PERCENT = 75.0;
        private const double DEFAULT_MIN_DARK_MATTER_PERCENT = 20.0;
        private const double DEFAULT_MAX_DARK_MATTER_PERCENT = 30.0;
        private const double DEFAULT_MIN_BARYONIC_MATTER_PERCENT = 4.0;
        private const double DEFAULT_MAX_BARYONIC_MATTER_PERCENT = 6.0;
        private const float DEFAULT_MIN_UNIVERSE_AGE = 5e9f;
        private const float DEFAULT_MAX_UNIVERSE_AGE = 20e9f;
        private const double DEFAULT_MIN_CONNECTIVITY_FACTOR = 0.05;
        private const double DEFAULT_MAX_CONNECTIVITY_FACTOR = 0.50;


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
        public IRandomGenerationAlgorithm RandomGenerator { get; set; }


        public GeneratorConfig()
        {
            this.RandomGenerator = new DotNetGenerator();

            this.MinDarkEnergyPercent = DEFAULT_MIN_DARK_ENERGY_PERCENT;
            this.MaxDarkEnergyPercent = DEFAULT_MAX_DARK_ENERGY_PERCENT;
            this.MinDarkMatterPercent = DEFAULT_MIN_DARK_MATTER_PERCENT;
            this.MaxDarkMatterPercent = DEFAULT_MAX_DARK_MATTER_PERCENT;
            this.MinBaryonicMatterPercent = DEFAULT_MIN_BARYONIC_MATTER_PERCENT;
            this.MaxBaryonicMatterPercent = DEFAULT_MAX_BARYONIC_MATTER_PERCENT;
            this.MinUniverseAge = DEFAULT_MIN_UNIVERSE_AGE;
            this.MaxUniverseAge = DEFAULT_MAX_UNIVERSE_AGE;
            this.MinConnectivityFactor = DEFAULT_MIN_CONNECTIVITY_FACTOR;
            this.MaxConnectivityFactor = DEFAULT_MAX_CONNECTIVITY_FACTOR;
        }
    }
}
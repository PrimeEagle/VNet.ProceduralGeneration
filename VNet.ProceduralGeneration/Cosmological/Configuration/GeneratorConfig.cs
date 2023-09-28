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
        private const float  DEFAULT_MIN_UNIVERSE_AGE = 5e9f;                                               // years
        private const float  DEFAULT_MAX_UNIVERSE_AGE = 20e9f;                                              // years
        private const double DEFAULT_MIN_CONNECTIVITY_FACTOR = 0.05;                                        // 0.0 - 1.0
        private const double DEFAULT_MAX_CONNECTIVITY_FACTOR = 0.50;                                        // 0.0 - 1.0
        private const double DEFAULT_BASELINE_EXPANSION_RATE = 70.0;                                        // km/s/Mpc
        private const double DEFAULT_BASELINE_COSMIC_MICROWAVE_BACKGROUND = 2.735;                          // Kelvin
        private const int   BARYONIC_MATTER_FILAMENT_BASE_COUNT = 1000;
        private const double BARYONIC_MATTER_FILAMENT_AGE_FACTOR = 10.0;
        private const double BARYONIC_MATTER_FILAMENT_MASS_FACTOR = 1 / 1e30;
        private const double BARYONIC_MATTER_FILAMENT_SIZE_FACTOR = 1 / 1e9;
        private const double BARYONIC_MATTER_FILAMENT_BARYONIC_MATTER_PERCENT_FACTOR = 100;
        private const double BARYONIC_MATTER_FILAMENT_DARK_MATTER_PERCENT_FACTOR = 150;
        private const double BARYONIC_MATTER_FILAMENT_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   DARK_MATTER_FILAMENT_BASE_COUNT = 1500;
        private const double DARK_MATTER_FILAMENT_AGE_FACTOR = 12.0;
        private const double DARK_MATTER_FILAMENT_MASS_FACTOR = 1 / 1e30;
        private const double DARK_MATTER_FILAMENT_SIZE_FACTOR = 1 / 1e9;
        private const double DARK_MATTER_FILAMENT_BARYONIC_MATTER_PERCENT_FACTOR = 200;
        private const double DARK_MATTER_FILAMENT_DARK_MATTER_PERCENT_FACTOR = 100;
        private const double DARK_MATTER_FILAMENT_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   BARYONIC_MATTER_NODE_BASE_COUNT = 300;
        private const double BARYONIC_MATTER_NODE_AGE_FACTOR = 5.0;
        private const double BARYONIC_MATTER_NODE_MASS_FACTOR = 1 / 1e30;
        private const double BARYONIC_MATTER_NODE_SIZE_FACTOR = 1 / 1e9;
        private const double BARYONIC_MATTER_NODE_BARYONIC_MATTER_PERCENT_FACTOR = 100;
        private const double BARYONIC_MATTER_NODE_DARK_MATTER_PERCENT_FACTOR = 200;
        private const double BARYONIC_MATTER_NODE_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   DARK_MATTER_NODE_BASE_COUNT = 500;
        private const double DARK_MATTER_NODE_AGE_FACTOR = 6.0;
        private const double DARK_MATTER_NODE_MASS_FACTOR = 1 / 1e30;
        private const double DARK_MATTER_NODE_SIZE_FACTOR = 1 / 1e9;
        private const double DARK_MATTER_NODE_BARYONIC_MATTER_PERCENT_FACTOR = 200;
        private const double DARK_MATTER_NODE_DARK_MATTER_PERCENT_FACTOR = 100;
        private const double DARK_MATTER_NODE_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   BARYONIC_MATTER_SHEET_BASE_COUNT = 300;
        private const double BARYONIC_MATTER_SHEET_AGE_FACTOR = 5.0;
        private const double BARYONIC_MATTER_SHEET_MASS_FACTOR = 1 / 1e30;
        private const double BARYONIC_MATTER_SHEET_SIZE_FACTOR = 1 / 1e9;
        private const double BARYONIC_MATTER_SHEET_BARYONIC_MATTER_PERCENT_FACTOR = 100;
        private const double BARYONIC_MATTER_SHEET_DARK_MATTER_PERCENT_FACTOR = 150;
        private const double BARYONIC_MATTER_SHEET_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   DARK_MATTER_SHEET_BASE_COUNT = 500;
        private const double DARK_MATTER_SHEET_AGE_FACTOR = 7.0;
        private const double DARK_MATTER_SHEET_MASS_FACTOR = 1 / 1e30;
        private const double DARK_MATTER_SHEET_SIZE_FACTOR = 1 / 1e9;
        private const double DARK_MATTER_SHEET_BARYONIC_MATTER_PERCENT_FACTOR = 200;
        private const double DARK_MATTER_SHEET_DARK_MATTER_PERCENT_FACTOR = 100;
        private const double DARK_MATTER_SHEET_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   BARYONIC_MATTER_VOID_BASE_COUNT = 1500;
        private const double BARYONIC_MATTER_VOID_AGE_FACTOR = 8.0;
        private const double BARYONIC_MATTER_VOID_MASS_FACTOR = 1 / 1e30;
        private const double BARYONIC_MATTER_VOID_SIZE_FACTOR = 1 / 1e9;
        private const double BARYONIC_MATTER_VOID_BARYONIC_MATTER_PERCENT_FACTOR = 100;
        private const double BARYONIC_MATTER_VOID_DARK_ENERGY_PERCENT_FACTOR = 100;
        private const int   DARK_MATTER_VOID_BASE_COUNT = 1400;
        private const double DARK_MATTER_VOID_AGE_FACTOR = 7.0;
        private const double DARK_MATTER_VOID_MASS_FACTOR = 1 / 1e30;
        private const double DARK_MATTER_VOID_SIZE_FACTOR = 1 / 1e9;
        private const double DARK_MATTER_VOID_DARK_MATTER_PERCENT_FACTOR = 100;
        private const double DARK_MATTER_VOID_DARK_ENERGY_PERCENT_FACTOR = 150;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_DENSITY_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_GRADIENT_MAGNITUDE_THRESHOLD_FACTOR = 0.2f;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_INTENSITY_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_SEED_MERGE_DISTANCE_THRESHOLD_FACTOR = 0.2f;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_SEED_MIN_DISTANCE_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_BARYONIC_MATTER_NODE_MAX_POSITIONAL_OFFSET = 0.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_DENSITY_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_GRADIENT_MAGNITUDE_THRESHOLD_FACTOR = 0.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_INTENSITY_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_SEED_MERGE_DISTANCE_THRESHOLD_FACTOR = 0.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_SEED_MIN_DISTANCE_THRESHOLD_FACTOR = 1.2f;
        private const float TOPOLOGY_DARK_MATTER_NODE_MAX_POSITIONAL_OFFSET = 0.2f;


        public float DimX { get; set; }
        public float DimY { get; set; }
        public float DimZ { get; set; }

        public float AverageDim
        {
            get { return CalculateAverageDim(); }
        }
        public double MinDarkEnergyPercent { get; set; }
        public double MaxDarkEnergyPercent { get; set; }
        public double MinDarkMatterPercent { get; set; }
        public double MaxDarkMatterPercent { get; set; }
        public double MinBaryonicMatterPercent { get; set; }
        public double MaxBaryonicMatterPercent { get; set; }
        public float  MinUniverseAge { get; set; }
        public float  MaxUniverseAge { get; set; }
        public double MinConnectivityFactor { get; set; }
        public double MaxConnectivityFactor { get; set; }
        public string HeightmapImageFile { get; set; }
        public float  GaussianSigma { get; set; }
        public double BaselineExpansionRate { get; set; }
        public double BaselineCosmicMicrowaveBackground { get; set; }
        public int BaryonicMatterFilamentBaseCount { get; set; }
        public double BaryonicMatterFilamentAgeFactor { get; set; }
        public double BaryonicMatterFilamentMassFactor { get; set; }
        public double BaryonicMatterFilamentSizeFactor { get; set; }
        public double BaryonicMatterFilamentBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterFilamentDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterFilamentDarkEnergyPercentFactor { get; set; }
        public int DarkMatterFilamentBaseCount { get; set; }
        public double DarkMatterFilamentAgeFactor { get; set; }
        public double DarkMatterFilamentMassFactor { get; set; }
        public double DarkMatterFilamentSizeFactor { get; set; }
        public double DarkMatterFilamentBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterFilamentDarkMatterPercentFactor { get; set; }
        public double DarkMatterFilamentDarkEnergyPercentFactor { get; set; }
        public int BaryonicMatterNodeBaseCount { get; set; }
        public double BaryonicMatterNodeAgeFactor { get; set; }
        public double BaryonicMatterNodeMassFactor { get; set; }
        public double BaryonicMatterNodeSizeFactor { get; set; }
        public double BaryonicMatterNodeBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterNodeDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterNodeDarkEnergyPercentFactor { get; set; }
        public int DarkMatterNodeBaseCount { get; set; }
        public double DarkMatterNodeAgeFactor { get; set; }
        public double DarkMatterNodeMassFactor { get; set; }
        public double DarkMatterNodeSizeFactor { get; set; }
        public double DarkMatterNodeBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterNodeDarkMatterPercentFactor { get; set; }
        public double DarkMatterNodeDarkEnergyPercentFactor { get; set; }
        public int BaryonicMatterSheetBaseCount { get; set; }
        public double BaryonicMatterSheetAgeFactor { get; set; }
        public double BaryonicMatterSheetMassFactor { get; set; }
        public double BaryonicMatterSheetSizeFactor { get; set; }
        public double BaryonicMatterSheetBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterSheetDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterSheetDarkEnergyPercentFactor { get; set; }
        public int DarkMatterSheetBaseCount { get; set; }
        public double DarkMatterSheetAgeFactor { get; set; }
        public double DarkMatterSheetMassFactor { get; set; }
        public double DarkMatterSheetSizeFactor { get; set; }
        public double DarkMatterSheetBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterSheetDarkMatterPercentFactor { get; set; }
        public double DarkMatterSheetDarkEnergyPercentFactor { get; set; }
        public int BaryonicMatterVoidBaseCount { get; set; }
        public double BaryonicMatterVoidAgeFactor { get; set; }
        public double BaryonicMatterVoidMassFactor { get; set; }
        public double BaryonicMatterVoidSizeFactor { get; set; }
        public double BaryonicMatterVoidBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterVoidDarkEnergyPercentFactor { get; set; }
        public int DarkMatterVoidBaseCount { get; set; }
        public double DarkMatterVoidAgeFactor { get; set; }
        public double DarkMatterVoidMassFactor { get; set; }
        public double DarkMatterVoidSizeFactor { get; set; }
        public double DarkMatterVoidDarkMatterPercentFactor { get; set; }
        public double DarkMatterVoidDarkEnergyPercentFactor { get; set; }
        public float TopologyBaryonicMatterNodeDensityThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeIntensityThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeSeedMergeDistanceThreshold {
            get
            {
                return this.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDim;
            }
        }

        public float TopologyBaryonicMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyBaryonicMatterNodeSeedMergeDistanceThreshold * this.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor;
            }
        }
        public float TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeMaxPositionalOffset { get; set; }


        public float TopologyDarkMatterNodeDensityThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeGradientMagnitudeThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeIntensityThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeSeedMergeDistanceThreshold
        {
            get
            {
                return this.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor * this.AverageDim;
            }
        }

        public float TopologyDarkMatterNodeSeedMinDistanceThreshold
        {
            get
            {
                return this.TopologyDarkMatterNodeSeedMergeDistanceThreshold * this.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor;
            }
        }
        public float TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeSeedMinDistanceThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeMaxPositionalOffset { get; set; }


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
            this.BaselineExpansionRate = DEFAULT_BASELINE_EXPANSION_RATE;
            this.BaselineCosmicMicrowaveBackground = DEFAULT_BASELINE_COSMIC_MICROWAVE_BACKGROUND;
            this.BaryonicMatterFilamentBaseCount = BARYONIC_MATTER_FILAMENT_BASE_COUNT;
            this.BaryonicMatterFilamentAgeFactor = BARYONIC_MATTER_FILAMENT_AGE_FACTOR;
            this.BaryonicMatterFilamentMassFactor = BARYONIC_MATTER_FILAMENT_MASS_FACTOR;
            this.BaryonicMatterFilamentSizeFactor = BARYONIC_MATTER_FILAMENT_SIZE_FACTOR;
            this.BaryonicMatterFilamentBaryonicMatterPercentFactor = BARYONIC_MATTER_FILAMENT_BARYONIC_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterFilamentDarkMatterPercentFactor = BARYONIC_MATTER_FILAMENT_DARK_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterFilamentDarkEnergyPercentFactor = BARYONIC_MATTER_FILAMENT_DARK_ENERGY_PERCENT_FACTOR;
            this.DarkMatterFilamentBaseCount = DARK_MATTER_FILAMENT_BASE_COUNT; 
            this.DarkMatterFilamentAgeFactor = DARK_MATTER_FILAMENT_AGE_FACTOR;
            this.DarkMatterFilamentMassFactor = DARK_MATTER_FILAMENT_MASS_FACTOR;
            this.DarkMatterFilamentSizeFactor = DARK_MATTER_FILAMENT_SIZE_FACTOR;
            this.DarkMatterFilamentBaryonicMatterPercentFactor = DARK_MATTER_FILAMENT_BARYONIC_MATTER_PERCENT_FACTOR;
            this.DarkMatterFilamentDarkMatterPercentFactor = DARK_MATTER_FILAMENT_DARK_MATTER_PERCENT_FACTOR;
            this.DarkMatterFilamentDarkEnergyPercentFactor = DARK_MATTER_FILAMENT_DARK_ENERGY_PERCENT_FACTOR;
            this.BaryonicMatterNodeBaseCount = BARYONIC_MATTER_NODE_BASE_COUNT;
            this.BaryonicMatterNodeAgeFactor = BARYONIC_MATTER_NODE_AGE_FACTOR;
            this.BaryonicMatterNodeMassFactor = BARYONIC_MATTER_NODE_MASS_FACTOR;
            this.BaryonicMatterNodeSizeFactor = BARYONIC_MATTER_NODE_SIZE_FACTOR;
            this.BaryonicMatterNodeBaryonicMatterPercentFactor = BARYONIC_MATTER_NODE_BARYONIC_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterNodeDarkMatterPercentFactor = BARYONIC_MATTER_NODE_DARK_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterNodeDarkEnergyPercentFactor = BARYONIC_MATTER_NODE_DARK_ENERGY_PERCENT_FACTOR;
            this.DarkMatterNodeBaseCount = DARK_MATTER_NODE_BASE_COUNT;
            this.DarkMatterNodeAgeFactor = DARK_MATTER_NODE_AGE_FACTOR;
            this.DarkMatterNodeMassFactor = DARK_MATTER_NODE_MASS_FACTOR;
            this.DarkMatterNodeSizeFactor = DARK_MATTER_NODE_SIZE_FACTOR;
            this.DarkMatterNodeBaryonicMatterPercentFactor = DARK_MATTER_NODE_BARYONIC_MATTER_PERCENT_FACTOR;
            this.DarkMatterNodeDarkMatterPercentFactor = DARK_MATTER_NODE_DARK_MATTER_PERCENT_FACTOR;
            this.DarkMatterNodeDarkEnergyPercentFactor = DARK_MATTER_NODE_DARK_ENERGY_PERCENT_FACTOR;
            this.BaryonicMatterSheetBaseCount = BARYONIC_MATTER_SHEET_BASE_COUNT;
            this.BaryonicMatterSheetAgeFactor = BARYONIC_MATTER_SHEET_AGE_FACTOR;
            this.BaryonicMatterSheetMassFactor = BARYONIC_MATTER_SHEET_MASS_FACTOR;
            this.BaryonicMatterSheetSizeFactor = BARYONIC_MATTER_SHEET_SIZE_FACTOR;
            this.BaryonicMatterSheetBaryonicMatterPercentFactor = BARYONIC_MATTER_SHEET_BARYONIC_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterSheetDarkMatterPercentFactor = BARYONIC_MATTER_SHEET_DARK_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterSheetDarkEnergyPercentFactor = BARYONIC_MATTER_SHEET_DARK_ENERGY_PERCENT_FACTOR;
            this.DarkMatterSheetBaseCount = DARK_MATTER_SHEET_BASE_COUNT; 
            this.DarkMatterSheetAgeFactor = DARK_MATTER_SHEET_AGE_FACTOR;
            this.DarkMatterSheetMassFactor = DARK_MATTER_SHEET_MASS_FACTOR;
            this.DarkMatterSheetSizeFactor = DARK_MATTER_SHEET_SIZE_FACTOR;
            this.DarkMatterSheetBaryonicMatterPercentFactor = DARK_MATTER_SHEET_BARYONIC_MATTER_PERCENT_FACTOR;
            this.DarkMatterSheetDarkMatterPercentFactor = DARK_MATTER_SHEET_DARK_MATTER_PERCENT_FACTOR;
            this.DarkMatterSheetDarkEnergyPercentFactor = DARK_MATTER_SHEET_DARK_ENERGY_PERCENT_FACTOR;
            this.BaryonicMatterVoidBaseCount = BARYONIC_MATTER_VOID_BASE_COUNT;
            this.BaryonicMatterVoidAgeFactor = BARYONIC_MATTER_VOID_AGE_FACTOR;
            this.BaryonicMatterVoidMassFactor = BARYONIC_MATTER_VOID_MASS_FACTOR;
            this.BaryonicMatterVoidSizeFactor = BARYONIC_MATTER_VOID_SIZE_FACTOR;
            this.BaryonicMatterVoidBaryonicMatterPercentFactor = BARYONIC_MATTER_VOID_BARYONIC_MATTER_PERCENT_FACTOR;
            this.BaryonicMatterVoidDarkEnergyPercentFactor = BARYONIC_MATTER_VOID_DARK_ENERGY_PERCENT_FACTOR;
            this.DarkMatterVoidBaseCount = DARK_MATTER_VOID_BASE_COUNT;
            this.DarkMatterVoidAgeFactor = DARK_MATTER_VOID_AGE_FACTOR;
            this.DarkMatterVoidMassFactor = DARK_MATTER_VOID_MASS_FACTOR;
            this.DarkMatterVoidSizeFactor = DARK_MATTER_VOID_SIZE_FACTOR;
            this.DarkMatterVoidDarkMatterPercentFactor = DARK_MATTER_VOID_DARK_MATTER_PERCENT_FACTOR;
            this.DarkMatterVoidDarkEnergyPercentFactor = DARK_MATTER_VOID_DARK_ENERGY_PERCENT_FACTOR;
            this.TopologyBaryonicMatterNodeDensityThresholdFactor = TOPOLOGY_BARYONIC_MATTER_NODE_DENSITY_THRESHOLD_FACTOR;
            this.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor = TOPOLOGY_BARYONIC_MATTER_NODE_GRADIENT_MAGNITUDE_THRESHOLD_FACTOR;
            this.TopologyBaryonicMatterNodeIntensityThresholdFactor = TOPOLOGY_BARYONIC_MATTER_NODE_INTENSITY_THRESHOLD_FACTOR;
            this.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor = TOPOLOGY_BARYONIC_MATTER_NODE_SEED_MERGE_DISTANCE_THRESHOLD_FACTOR;
            this.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor = TOPOLOGY_BARYONIC_MATTER_NODE_SEED_MIN_DISTANCE_THRESHOLD_FACTOR;
            this.TopologyBaryonicMatterNodeMaxPositionalOffset = TOPOLOGY_BARYONIC_MATTER_NODE_MAX_POSITIONAL_OFFSET;
            this.TopologyDarkMatterNodeDensityThresholdFactor = TOPOLOGY_DARK_MATTER_NODE_DENSITY_THRESHOLD_FACTOR;
            this.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor = TOPOLOGY_DARK_MATTER_NODE_GRADIENT_MAGNITUDE_THRESHOLD_FACTOR;
            this.TopologyDarkMatterNodeIntensityThresholdFactor = TOPOLOGY_DARK_MATTER_NODE_INTENSITY_THRESHOLD_FACTOR;
            this.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor = TOPOLOGY_DARK_MATTER_NODE_SEED_MERGE_DISTANCE_THRESHOLD_FACTOR;
            this.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor = TOPOLOGY_DARK_MATTER_NODE_SEED_MIN_DISTANCE_THRESHOLD_FACTOR;
            this.TopologyDarkMatterNodeMaxPositionalOffset = TOPOLOGY_DARK_MATTER_NODE_MAX_POSITIONAL_OFFSET;
        }

        private float CalculateAverageDim()
        {
            return (DimX + DimY + DimZ) / 3;
        }
    }
}
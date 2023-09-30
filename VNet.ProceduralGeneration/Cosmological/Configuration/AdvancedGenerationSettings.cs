using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AdvancedGenerationSettings : ISettings
    {
        public BaryonicMatterNodeGenerationSettings BaryonicMatterNode { get; set; }
        public BaryonicMatterFilamentGenerationSettings BaryonicMatterFilament { get; set; }
        public BaryonicMatterSheetGenerationSettings BaryonicMatterSheet { get; set; }
        public BaryonicMatterVoidGenerationSettings BaryonicMatterVoid { get; set; }
        public DarkMatterNodeGenerationSettings DarkMatterNode { get; set; }
        public DarkMatterFilamentGenerationSettings DarkMatterFilament { get; set; }
        public DarkMatterSheetGenerationSettings DarkMatterSheet { get; set; }
        public DarkMatterVoidGenerationSettings DarkMatterVoid { get; set; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 1 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 1 objects are the highest level in the hierarchy and benefit the most from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel1 { get; set; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 2 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 2 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 3 and 4 objects, but less than Level 1 objects.")]
        public int MaxDegreesOfParallelismLevel2 { get; set; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 3 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 3 objects are intermediate in the hierarchy and benefit from higher levels of parallelism more than Level 4 objects, but less than Level 1 and 2 objects.")]
        public int MaxDegreesOfParallelismLevel3 { get; set; }

        [Required]
        [Range(1, 64)]
        [DisplayName("Max Degrees of Parallelism for Level 4 Objects")]
        [Tooltip("When using multiple processor cores, the maximum number of parallel tasks that can be run. Level 4 objects are the lowest in the hierarchy and benefit the least from higher levels of parallelism.")]
        public int MaxDegreesOfParallelismLevel4 { get; set; }

        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        [DisplayName("Gaussian Sigm")]
        [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
        public float GaussianSigma { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [DisplayName("Baseline Expansion Rate")]
        [Tooltip("The baseline expansion rate to use for comparisons. Defaults to expansion rate of the real universe. (km/s/Mpc)")]
        public double BaselineExpansionRate { get; set; }

        [Required]
        [Range(0, 10e32)]
        [DisplayName("Baseline Cosmic Microwave Background")]
        [Tooltip("The baseline cosmic microwave background to user for comparisons. Defaults to the cosmic microwave backgroud of the real univerrse. (Kelvin)")]
        public double BaselineCosmicMicrowaveBackground { get; set; }

        [Required]
        [Range(0, 100)]
        [LessThanOrEqualToProperty(nameof(MaxConnectivityFactor))]
        [DisplayName("Min Connectivity Factor")]
        [Tooltip("The minimum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MinConnectivityFactor { get; set; }

        [Required]
        [Range(0, 100)]
        [GreaterThanOrEqualToProperty(nameof(MinConnectivityFactor))]
        [DisplayName("Max Connectivity Factor")]
        [Tooltip("The maximum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MaxConnectivityFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Density Threshold Factor")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeDensityThresholdFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Gradient Magnitude Threshold Factor")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Intensity Threshold Factor")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeIntensityThresholdFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Merge Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMergeDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Min Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMinDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Baryonic Matter Node Max Positional Offset")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMaxPositionalOffset { get; set; }

        [DisplayName("Topology Dark Matter Node Density Threshold Factor")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeDensityThresholdFactor { get; set; }

        [DisplayName("Topology Dark Matter Node Gradient Magnitude Threshold Factor")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeGradientMagnitudeThresholdFactor { get; set; }

        [DisplayName("Topology Dark Matter Node Intensity Threshold Factor")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeIntensityThresholdFactor { get; set; }

        [DisplayName("Topology Dark Matter Node Merge Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMergeDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Dark Matter Node Min Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMinDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Dark Matter Node Max Positional Offset")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMaxPositionalOffset { get; set; }




        public AdvancedGenerationSettings()
        {
            this.BaryonicMatterNode = new BaryonicMatterNodeGenerationSettings();
            this.BaryonicMatterFilament = new BaryonicMatterFilamentGenerationSettings();
            this.BaryonicMatterSheet = new BaryonicMatterSheetGenerationSettings();
            this.BaryonicMatterVoid = new BaryonicMatterVoidGenerationSettings();
            this.DarkMatterNode = new DarkMatterNodeGenerationSettings();
            this.DarkMatterFilament = new DarkMatterFilamentGenerationSettings();
            this.DarkMatterSheet = new DarkMatterSheetGenerationSettings();
            this.DarkMatterVoid = new DarkMatterVoidGenerationSettings();

            this.MaxDegreesOfParallelismLevel1 = ConfigConstants.MaxDegreesOfParallelismLevel1;
            this.MaxDegreesOfParallelismLevel2 = ConfigConstants.MaxDegreesOfParallelismLevel2;
            this.MaxDegreesOfParallelismLevel3 = ConfigConstants.MaxDegreesOfParallelismLevel3;
            this.MaxDegreesOfParallelismLevel4 = ConfigConstants.MaxDegreesOfParallelismLevel4;
            this.RandomGenerator = new DotNetGenerator();
            this.BaselineExpansionRate = ConfigConstants.BaselineExpansionRate;
            this.BaselineCosmicMicrowaveBackground = ConfigConstants.BaselineCosmicMicrowaveBackground;
            this.MinConnectivityFactor = ConfigConstants.MinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.MaxConnectivityFactor;
            this.TopologyBaryonicMatterNodeDensityThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeDensityThresholdFactor;
            this.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor;
            this.TopologyBaryonicMatterNodeIntensityThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeIntensityThresholdFactor;
            this.TopologyBaryonicMatterNodeMergeDistanceThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeMergeDistanceThresholdFactor;
            this.TopologyBaryonicMatterNodeMinDistanceThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeMinDistanceThresholdFactor;
            this.TopologyBaryonicMatterNodeMaxPositionalOffset = ConfigConstants.TopologyBaryonicMatterNodeMaxPositionalOffset;
            this.TopologyDarkMatterNodeDensityThresholdFactor = ConfigConstants.TopologyDarkMatterNodeDensityThresholdFactor;
            this.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor = ConfigConstants.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor;
            this.TopologyDarkMatterNodeIntensityThresholdFactor = ConfigConstants.TopologyDarkMatterNodeIntensityThresholdFactor;
            this.TopologyDarkMatterNodeMergeDistanceThresholdFactor = ConfigConstants.TopologyDarkMatterNodeMergeDistanceThresholdFactor;
            this.TopologyDarkMatterNodeMinDistanceThresholdFactor = ConfigConstants.TopologyDarkMatterNodeMinDistanceThresholdFactor;
            this.TopologyDarkMatterNodeMaxPositionalOffset = ConfigConstants.TopologyDarkMatterNodeMaxPositionalOffset;
        }
    }
}
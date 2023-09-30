using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AdvancedGenerationSettings : ISettings
    {
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

        [DisplayName("Baryonic Matter Node Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Node Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeMassFactor { get; set; }

        [DisplayName("Baryonic Matter Node Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Node Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Node Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Node Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeDarkEnergyPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentMassFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentDarkEnergyPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetMassFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetDarkEnergyPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Void Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Void Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidMassFactor { get; set; }

        [DisplayName("Baryonic Matter Void Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Void Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Void Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidDarkEnergyPercentFactor { get; set; }

        [DisplayName("Dark Matter Node Age Factor")]
        [Tooltip("")]
        public double DarkMatterNodeAgeFactor { get; set; }

        [DisplayName("Dark Matter Node Mass Factor")]
        [Tooltip("")]
        public double DarkMatterNodeMassFactor { get; set; }

        [DisplayName("Dark Matter Node Size Factor")]
        [Tooltip("")]
        public double DarkMatterNodeSizeFactor { get; set; }

        [DisplayName("Dark Matter Node Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Node Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Node Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeDarkEnergyPercentFactor { get; set; }

        [DisplayName("Dark Matter Filament Age Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentAgeFactor { get; set; }

        [DisplayName("Dark Matter Filament Mass Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentMassFactor { get; set; }

        [DisplayName("Dark Matter Filament Size Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentSizeFactor { get; set; }

        [DisplayName("Dark Matter Filament Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Filament Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Filament Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentDarkEnergyPercentFactor { get; set; }

        [DisplayName("Dark Matter Sheet Age Factor")]
        [Tooltip("")]
        public double DarkMatterSheetAgeFactor { get; set; }

        [DisplayName("Dark Matter Sheet Mass Factor")]
        [Tooltip("")]
        public double DarkMatterSheetMassFactor { get; set; }

        [DisplayName("Dark Matter Sheet Size Factor")]
        [Tooltip("")]
        public double DarkMatterSheetSizeFactor { get; set; }

        [DisplayName("Dark Matter Sheet Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Sheet Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Sheet Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetDarkEnergyPercentFactor { get; set; }

        [DisplayName("Dark Matter Void Age Factor")]
        [Tooltip("")]
        public double DarkMatterVoidAgeFactor { get; set; }

        [DisplayName("Dark Matter Void Mass Factor")]
        [Tooltip("")]
        public double DarkMatterVoidMassFactor { get; set; }

        [DisplayName("Dark Matter Void Size Factor")]
        [Tooltip("")]
        public double DarkMatterVoidSizeFactor { get; set; }

        [DisplayName("Dark Matter Void Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterVoidDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Void Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterVoidDarkEnergyPercentFactor { get; set; }

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
            this.MaxDegreesOfParallelismLevel1 = ConfigConstants.MaxDegreesOfParallelismLevel1;
            this.MaxDegreesOfParallelismLevel2 = ConfigConstants.MaxDegreesOfParallelismLevel2;
            this.MaxDegreesOfParallelismLevel3 = ConfigConstants.MaxDegreesOfParallelismLevel3;
            this.MaxDegreesOfParallelismLevel4 = ConfigConstants.MaxDegreesOfParallelismLevel4;
            this.RandomGenerator = new DotNetGenerator();
            this.BaselineExpansionRate = ConfigConstants.BaselineExpansionRate;
            this.BaselineCosmicMicrowaveBackground = ConfigConstants.BaselineCosmicMicrowaveBackground;
            this.MinConnectivityFactor = ConfigConstants.MinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.MaxConnectivityFactor;
            this.BaryonicMatterFilamentAgeFactor = ConfigConstants.BaryonicMatterFilamentAgeFactor;
            this.BaryonicMatterFilamentMassFactor = ConfigConstants.BaryonicMatterFilamentMassFactor;
            this.BaryonicMatterFilamentSizeFactor = ConfigConstants.BaryonicMatterFilamentSizeFactor;
            this.BaryonicMatterFilamentBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentBaryonicMatterPercentFactor;
            this.BaryonicMatterFilamentDarkMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentDarkMatterPercentFactor;
            this.BaryonicMatterFilamentDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterFilamentDarkEnergyPercentFactor;
            this.DarkMatterFilamentAgeFactor = ConfigConstants.DarkMatterFilamentAgeFactor;
            this.DarkMatterFilamentMassFactor = ConfigConstants.DarkMatterFilamentMassFactor;
            this.DarkMatterFilamentSizeFactor = ConfigConstants.DarkMatterFilamentSizeFactor;
            this.DarkMatterFilamentBaryonicMatterPercentFactor = ConfigConstants.DarkMatterFilamentBaryonicMatterPercentFactor;
            this.DarkMatterFilamentDarkMatterPercentFactor = ConfigConstants.DarkMatterFilamentDarkMatterPercentFactor;
            this.DarkMatterFilamentDarkEnergyPercentFactor = ConfigConstants.DarkMatterFilamentDarkEnergyPercentFactor;
            this.BaryonicMatterNodeAgeFactor = ConfigConstants.BaryonicMatterNodeAgeFactor;
            this.BaryonicMatterNodeMassFactor = ConfigConstants.BaryonicMatterNodeMassFactor;
            this.BaryonicMatterNodeSizeFactor = ConfigConstants.BaryonicMatterNodeSizeFactor;
            this.BaryonicMatterNodeBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterNodeBaryonicMatterPercentFactor;
            this.BaryonicMatterNodeDarkMatterPercentFactor = ConfigConstants.BaryonicMatterNodeDarkMatterPercentFactor;
            this.BaryonicMatterNodeDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterNodeDarkEnergyPercentFactor;
            this.DarkMatterNodeAgeFactor = ConfigConstants.DarkMatterNodeAgeFactor;
            this.DarkMatterNodeMassFactor = ConfigConstants.DarkMatterNodeMassFactor;
            this.DarkMatterNodeSizeFactor = ConfigConstants.DarkMatterNodeSizeFactor;
            this.DarkMatterNodeBaryonicMatterPercentFactor = ConfigConstants.DarkMatterNodeBaryonicMatterPercentFactor;
            this.DarkMatterNodeDarkMatterPercentFactor = ConfigConstants.DarkMatterNodeDarkMatterPercentFactor;
            this.DarkMatterNodeDarkEnergyPercentFactor = ConfigConstants.DarkMatterNodeDarkEnergyPercentFactor;
            this.BaryonicMatterSheetAgeFactor = ConfigConstants.BaryonicMatterSheetAgeFactor;
            this.BaryonicMatterSheetMassFactor = ConfigConstants.BaryonicMatterSheetMassFactor;
            this.BaryonicMatterSheetSizeFactor = ConfigConstants.BaryonicMatterSheetSizeFactor;
            this.BaryonicMatterSheetBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterSheetBaryonicMatterPercentFactor;
            this.BaryonicMatterSheetDarkMatterPercentFactor = ConfigConstants.BaryonicMatterSheetDarkMatterPercentFactor;
            this.BaryonicMatterSheetDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterSheetDarkEnergyPercentFactor;
            this.DarkMatterSheetAgeFactor = ConfigConstants.DarkMatterSheetAgeFactor;
            this.DarkMatterSheetMassFactor = ConfigConstants.DarkMatterSheetMassFactor;
            this.DarkMatterSheetSizeFactor = ConfigConstants.DarkMatterSheetSizeFactor;
            this.DarkMatterSheetBaryonicMatterPercentFactor = ConfigConstants.DarkMatterSheetBaryonicMatterPercentFactor;
            this.DarkMatterSheetDarkMatterPercentFactor = ConfigConstants.DarkMatterSheetDarkMatterPercentFactor;
            this.DarkMatterSheetDarkEnergyPercentFactor = ConfigConstants.DarkMatterSheetDarkEnergyPercentFactor;
            this.BaryonicMatterVoidAgeFactor = ConfigConstants.BaryonicMatterVoidAgeFactor;
            this.BaryonicMatterVoidMassFactor = ConfigConstants.BaryonicMatterVoidMassFactor;
            this.BaryonicMatterVoidSizeFactor = ConfigConstants.BaryonicMatterVoidSizeFactor;
            this.BaryonicMatterVoidBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterVoidBaryonicMatterPercentFactor;
            this.BaryonicMatterVoidDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterVoidDarkEnergyPercentFactor;
            this.DarkMatterVoidAgeFactor = ConfigConstants.DarkMatterVoidAgeFactor;
            this.DarkMatterVoidMassFactor = ConfigConstants.DarkMatterVoidMassFactor;
            this.DarkMatterVoidSizeFactor = ConfigConstants.DarkMatterVoidSizeFactor;
            this.DarkMatterVoidDarkMatterPercentFactor = ConfigConstants.DarkMatterVoidDarkMatterPercentFactor;
            this.DarkMatterVoidDarkEnergyPercentFactor = ConfigConstants.DarkMatterVoidDarkEnergyPercentFactor;
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
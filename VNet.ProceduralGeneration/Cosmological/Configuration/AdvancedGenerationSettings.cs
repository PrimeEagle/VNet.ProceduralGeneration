using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AdvancedGenerationSettings : ISettings
    {
        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm RandomGenerator { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        [DisplayName("")]
        [Tooltip("")]
        public float GaussianSigma { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaselineExpansionRate { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaselineCosmicMicrowaveBackground { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterNodeDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterFilamentDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterSheetDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterVoidAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterVoidMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterVoidSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterVoidBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double BaryonicMatterVoidDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterNodeDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterFilamentDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetBaryonicMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterSheetDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterVoidAgeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterVoidMassFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterVoidSizeFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterVoidDarkMatterPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public double DarkMatterVoidDarkEnergyPercentFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeDensityThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeIntensityThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMergeDistanceThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMinDistanceThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyBaryonicMatterNodeMaxPositionalOffset { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeDensityThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeGradientMagnitudeThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeIntensityThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMergeDistanceThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMinDistanceThresholdFactor { get; set; }

        [DisplayName("")]
        [Tooltip("")]
        public float TopologyDarkMatterNodeMaxPositionalOffset { get; set; }



        public AdvancedGenerationSettings()
        {
            this.RandomGenerator = new DotNetGenerator();
            this.BaselineExpansionRate = ConfigConstants.DefaultBaselineExpansionRate;
            this.BaselineCosmicMicrowaveBackground = ConfigConstants.DefaultBaselineCosmicMicrowaveBackground;
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
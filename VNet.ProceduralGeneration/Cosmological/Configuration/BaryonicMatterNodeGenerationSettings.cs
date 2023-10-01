using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterNodeGenerationSettings : ISettings
    {
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountAgeFactor { get; set; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountMassFactor { get; set; }

        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountSizeFactor { get; set; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) node count. Higher value results in less nodes.")]
        public double CountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) node count. Higher value results in less nodes.")]
        public double CountDarkMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountDarkEnergyPercentFactor { get; set; }

        [DisplayName("Topology Density Threshold Factor")]
        [Tooltip("")]
        public float TopologyDensityThresholdFactor { get; set; }

        [DisplayName("Topology Gradient Magnitude Threshold Factor")]
        [Tooltip("")]
        public float TopologyGradientMagnitudeThresholdFactor { get; set; }

        [DisplayName("Topology Intensity Threshold Factor")]
        [Tooltip("")]
        public float TopologyIntensityThresholdFactor { get; set; }

        [DisplayName("Topology Merge Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyMergeDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Min Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyMinDistanceThresholdFactor { get; set; }

        [DisplayName("Topology Max Positional Offset")]
        [Tooltip("")]
        public float TopologyMaxPositionalOffset { get; set; }



        public BaryonicMatterNodeGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterNode.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterNode.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterNode.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterNode.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterNode.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterNode.CountDarkEnergyPercentFactor;
            this.TopologyDensityThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyDensityThresholdFactor;
            this.TopologyGradientMagnitudeThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyGradientMagnitudeThresholdFactor;
            this.TopologyIntensityThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyIntensityThresholdFactor;
            this.TopologyMergeDistanceThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyMergeDistanceThresholdFactor;
            this.TopologyMinDistanceThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyMinDistanceThresholdFactor;
            this.TopologyMaxPositionalOffset = ConfigConstants.BaryonicMatterNode.TopologyMaxPositionalOffset;
        }
    }
}
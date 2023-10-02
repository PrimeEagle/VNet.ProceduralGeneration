using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterNodeGenerationSettings : ISettings
    {
        [Range(0, double.MaxValue)]
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountAgeFactor { get; init; }

        [Range(0, double.MaxValue)]
        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountMassFactor { get; init; }

        [Range(0, double.MaxValue)]
        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountSizeFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountDarkMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) node count. Higher value results in fewer nodes.")]
        public double CountBaryonicMatterPercentFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountBaryonicMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) node count. Higher value results in fewer nodes.")]
        public double CountDarkMatterPercentFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CountBaryonicMatterPercentFactor), nameof(CountDarkMatterPercentFactor) })]
        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
        public double CountDarkEnergyPercentFactor { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Topology Intensity Threshold Factor")]
        [Tooltip("Weighting factor for the average intensity of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
        public float TopologyIntensityThresholdFactor { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Topology Gradient Magnitude Threshold Factor")]
        [Tooltip("Weighting factor for the max gradient of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
        public float TopologyGradientMagnitudeThresholdFactor { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Topology Merge Distance Threshold Factor")]
        [Tooltip("Weighting factor for merge distance between nodes. Used to merge nodes. Higher value results in fewer, but bigger, nodes. ")]
        public float TopologyMergeDistanceThresholdFactor { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Topology Min Distance Threshold Factor")]
        [Tooltip("Weighting factor for distance between nodes. Used to remove the less intense of nodes that are too close. Higher value results in fewer nodes.")]
        public float TopologyMinDistanceThresholdFactor { get; init; }

        [Range(0, float.MaxValue)]
        [DisplayName("Topology Max Positional Offset")]
        [Tooltip("When positioning nodes, the max distance they can randomly deviate from positions calculated from the heightmap.")]
        public float TopologyMaxPositionalOffset { get; init; }




        public BaryonicMatterNodeGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterNode.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterNode.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterNode.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterNode.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterNode.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterNode.CountDarkEnergyPercentFactor;
            this.TopologyGradientMagnitudeThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyGradientMagnitudeThresholdFactor;
            this.TopologyIntensityThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyIntensityThresholdFactor;
            this.TopologyMergeDistanceThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyMergeDistanceThresholdFactor;
            this.TopologyMinDistanceThresholdFactor = ConfigConstants.BaryonicMatterNode.TopologyMinDistanceThresholdFactor;
            this.TopologyMaxPositionalOffset = ConfigConstants.BaryonicMatterNode.TopologyMaxPositionalOffset;
        }
    }
}
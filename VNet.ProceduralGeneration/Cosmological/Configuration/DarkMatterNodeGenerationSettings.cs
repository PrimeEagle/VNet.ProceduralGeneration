using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterNodeGenerationSettings : ISettings
    {
        [Range(0, 100)]
        [DisplayName("Count Tolerance Percentage")]
        [Tooltip("Deviation allowed from calculated node count, as a \u00b1 percentage.")]
        public float CountTolerancePercentage { get; init; }

        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
        public float CountAgeFactor { get; init; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
        public float CountMassFactor { get; init; }

        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on dark matter node count. Higher value results in more nodes.")]
        public float CountSizeFactor { get; init; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in more nodes.")]
        public float CountBaryonicMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in fewer nodes.")]
        public float CountDarkMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter node count. Higher value results in more nodes.")]
        public float CountDarkEnergyPercentFactor { get; init; }

        [DisplayName("Topology Gradient Magnitude Threshold Factor")]
        [Tooltip("Weighting factor for the average intensity of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
        public float TopologyGradientMagnitudeThresholdFactor { get; init; }

        [DisplayName("Topology Intensity Threshold Factor")]
        [Tooltip("Weighting factor for the max gradient of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
        public float TopologyIntensityThresholdFactor { get; init; }

        [DisplayName("Topology Merge Distance Threshold Factor")]
        [Tooltip("Weighting factor for merge distance between nodes. Used to merge nodes. Higher value results in fewer, but bigger, nodes. ")]
        public float TopologyMergeDistanceThresholdFactor { get; init; }

        [DisplayName("Topology Min Distance Threshold Factor")]
        [Tooltip("Weighting factor for distance between nodes. Used to remove the less intense of nodes that are too close. Higher value results in fewer nodes.")]
        public float TopologyMinDistanceThresholdFactor { get; init; }

        [DisplayName("Topology Max Positional Offset")]
        [Tooltip("When positioning nodes, the max distance they can randomly deviate from positions calculated from the heightmap.")]
        public float TopologyMaxPositionalOffset { get; init; }

        [Range(0, 100)]
        [DisplayName("Topology Z Variance Percent")]
        [Tooltip("When extruding nodes into the Z dimension, the amount of variance allowed as a percentage of map depth. Value of 100 allows any depth within the map.")]
        public float TopologyZVariancePercent { get; init; }



        public DarkMatterNodeGenerationSettings()
        {
            this.CountTolerancePercentage = ConfigConstants.DarkMatterNode.CountTolerancePercentage;
            this.CountAgeFactor = ConfigConstants.DarkMatterNode.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterNode.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterNode.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterNode.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterNode.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterNode.CountDarkEnergyPercentFactor;
            this.TopologyGradientMagnitudeThresholdFactor = ConfigConstants.DarkMatterNode.TopologyGradientMagnitudeThresholdFactor;
            this.TopologyIntensityThresholdFactor = ConfigConstants.DarkMatterNode.TopologyIntensityThresholdFactor;
            this.TopologyMergeDistanceThresholdFactor = ConfigConstants.DarkMatterNode.TopologyMergeDistanceThresholdFactor;
            this.TopologyMinDistanceThresholdFactor = ConfigConstants.DarkMatterNode.TopologyMinDistanceThresholdFactor;
            this.TopologyMaxPositionalOffset = ConfigConstants.DarkMatterNode.TopologyMaxPositionalOffset;
            this.TopologyZVariancePercent = ConfigConstants.DarkMatterNode.TopologyZVariancePercent;
        }
    }
}
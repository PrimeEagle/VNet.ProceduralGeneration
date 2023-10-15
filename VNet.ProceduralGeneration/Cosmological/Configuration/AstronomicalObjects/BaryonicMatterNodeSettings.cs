using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class BaryonicMatterNodeSettings : ISettings
{
    [Range(0, float.MaxValue)]
    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
    public float CountAgeFactor { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CountDarkMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of baryonic matter (normal matter) in the universe on baryonic matter (normal matter) node count. Higher value results in fewer nodes.")]
    public float CountBaryonicMatterPercentFactor { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CountBaryonicMatterPercentFactor), nameof(CountDarkMatterPercentFactor) })]
    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
    public float CountDarkEnergyPercentFactor { get; init; }

    [Range(0, 100)]
    [PercentageWithProperties(new[] { nameof(CountBaryonicMatterPercentFactor), nameof(CountDarkEnergyPercentFactor) })]
    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on baryonic matter (normal matter) node count. Higher value results in fewer nodes.")]
    public float CountDarkMatterPercentFactor { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the mass of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
    public float CountMassFactor { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on baryonic matter (normal matter) node count. Higher value results in more nodes.")]
    public float CountSizeFactor { get; init; }

    [Range(0, 100)]
    [DisplayName("Count Tolerance Percentage")]
    [Tooltip("Deviation allowed from calculated node count, as a \u00b1 percentage.")]
    public float CountTolerancePercentage { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Topology Gradient Magnitude Threshold Factor")]
    [Tooltip("Weighting factor for the max gradient of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
    public float TopologyGradientMagnitudeThresholdFactor { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Topology Intensity Threshold Factor")]
    [Tooltip("Weighting factor for the average intensity of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
    public float TopologyIntensityThresholdFactor { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Topology Max Positional Offset")]
    [Tooltip("When positioning nodes, the max distance they can randomly deviate from positions calculated from the heightmap.")]
    public float TopologyMaxPositionalOffset { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Topology Merge Distance Threshold Factor")]
    [Tooltip("Weighting factor for merge distance between nodes. Used to merge nodes. Higher value results in fewer, but bigger, nodes. ")]
    public float TopologyMergeDistanceThresholdFactor { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Topology Min Distance Threshold Factor")]
    [Tooltip("Weighting factor for distance between nodes. Used to remove the less intense of nodes that are too close. Higher value results in fewer nodes.")]
    public float TopologyMinDistanceThresholdFactor { get; init; }

    [Range(0, 100)]
    [DisplayName("Topology Z Variance Percent")]
    [Tooltip("When extruding nodes into the Z dimension, the amount of variance allowed as a percentage of map depth. Value of 100 allows any depth within the map.")]
    public float TopologyZVariancePercent { get; init; }

    public BaryonicMatterNodeSettings()
    {
        CountTolerancePercentage = Constants.Advanced.Objects.BaryonicMatterNode.CountTolerancePercentage;
        CountAgeFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountAgeFactor;
        CountMassFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountMassFactor;
        CountSizeFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountSizeFactor;
        CountBaryonicMatterPercentFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = Constants.Advanced.Objects.BaryonicMatterNode.CountDarkEnergyPercentFactor;
        TopologyGradientMagnitudeThresholdFactor = Constants.Advanced.Objects.BaryonicMatterNode.TopologyGradientMagnitudeThresholdFactor;
        TopologyIntensityThresholdFactor = Constants.Advanced.Objects.BaryonicMatterNode.TopologyIntensityThresholdFactor;
        TopologyMergeDistanceThresholdFactor = Constants.Advanced.Objects.BaryonicMatterNode.TopologyMergeDistanceThresholdFactor;
        TopologyMinDistanceThresholdFactor = Constants.Advanced.Objects.BaryonicMatterNode.TopologyMinDistanceThresholdFactor;
        TopologyMaxPositionalOffset = Constants.Advanced.Objects.BaryonicMatterNode.TopologyMaxPositionalOffset;
        TopologyZVariancePercent = Constants.Advanced.Objects.BaryonicMatterNode.TopologyZVariancePercent;
    }
}
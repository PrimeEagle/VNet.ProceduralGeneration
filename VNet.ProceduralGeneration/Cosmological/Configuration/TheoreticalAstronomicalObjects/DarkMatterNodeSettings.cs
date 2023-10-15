using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjects;

public class DarkMatterNodeSettings : ISettings
{
    [DisplayName("Count Age Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
    public float CountAgeFactor { get; init; }

    [DisplayName("Count Baryonic Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in more nodes.")]
    public float CountBaryonicMatterPercentFactor { get; init; }

    [DisplayName("Count Dark Energy Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter node count. Higher value results in more nodes.")]
    public float CountDarkEnergyPercentFactor { get; init; }

    [DisplayName("Count Dark Matter Percent Factor")]
    [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in fewer nodes.")]
    public float CountDarkMatterPercentFactor { get; init; }

    [DisplayName("Count Mass Factor")]
    [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
    public float CountMassFactor { get; init; }

    [DisplayName("Count Size Factor")]
    [Tooltip("Weighting factor for the size of the universe on dark matter node count. Higher value results in more nodes.")]
    public float CountSizeFactor { get; init; }

    [Range(0, 100)]
    [DisplayName("Count Tolerance Percentage")]
    [Tooltip("Deviation allowed from calculated node count, as a \u00b1 percentage.")]
    public float CountTolerancePercentage { get; init; }

    [DisplayName("Topology Gradient Magnitude Threshold Factor")]
    [Tooltip("Weighting factor for the average intensity of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
    public float TopologyGradientMagnitudeThresholdFactor { get; init; }

    [DisplayName("Topology Intensity Threshold Factor")]
    [Tooltip("Weighting factor for the max gradient of the heightmap. Used to find nodes. Higher value results in fewer nodes.")]
    public float TopologyIntensityThresholdFactor { get; init; }

    [DisplayName("Topology Max Positional Offset")]
    [Tooltip("When positioning nodes, the max distance they can randomly deviate from positions calculated from the heightmap.")]
    public float TopologyMaxPositionalOffset { get; init; }

    [DisplayName("Topology Merge Distance Threshold Factor")]
    [Tooltip("Weighting factor for merge distance between nodes. Used to merge nodes. Higher value results in fewer, but bigger, nodes. ")]
    public float TopologyMergeDistanceThresholdFactor { get; init; }

    [DisplayName("Topology Min Distance Threshold Factor")]
    [Tooltip("Weighting factor for distance between nodes. Used to remove the less intense of nodes that are too close. Higher value results in fewer nodes.")]
    public float TopologyMinDistanceThresholdFactor { get; init; }

    [Range(0, 100)]
    [DisplayName("Topology Z Variance Percent")]
    [Tooltip("When extruding nodes into the Z dimension, the amount of variance allowed as a percentage of map depth. Value of 100 allows any depth within the map.")]
    public float TopologyZVariancePercent { get; init; }

    public DarkMatterNodeSettings()
    {
        CountTolerancePercentage = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountTolerancePercentage;
        CountAgeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountAgeFactor;
        CountMassFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountMassFactor;
        CountSizeFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountSizeFactor;
        CountBaryonicMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountBaryonicMatterPercentFactor;
        CountDarkMatterPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountDarkMatterPercentFactor;
        CountDarkEnergyPercentFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.CountDarkEnergyPercentFactor;
        TopologyGradientMagnitudeThresholdFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyGradientMagnitudeThresholdFactor;
        TopologyIntensityThresholdFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyIntensityThresholdFactor;
        TopologyMergeDistanceThresholdFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyMergeDistanceThresholdFactor;
        TopologyMinDistanceThresholdFactor = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyMinDistanceThresholdFactor;
        TopologyMaxPositionalOffset = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyMaxPositionalOffset;
        TopologyZVariancePercent = Constants.Advanced.TheoreticalObjects.DarkMatterNode.TopologyZVariancePercent;
    }
}
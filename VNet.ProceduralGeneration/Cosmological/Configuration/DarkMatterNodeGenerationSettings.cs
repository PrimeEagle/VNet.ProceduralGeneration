﻿using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterNodeGenerationSettings : ISettings
    {
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
        public double CountAgeFactor { get; init; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter node count. Higher value results in more nodes.")]
        public double CountMassFactor { get; init; }

        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on dark matter node count. Higher value results in more nodes.")]
        public double CountSizeFactor { get; init; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in more nodes.")]
        public double CountBaryonicMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter node count. Higher value results in less nodes.")]
        public double CountDarkMatterPercentFactor { get; init; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter node count. Higher value results in more nodes.")]
        public double CountDarkEnergyPercentFactor { get; init; }

        [DisplayName("Topology Density Threshold Factor")]
        [Tooltip("")]
        public float TopologyDensityThresholdFactor { get; init; }

        [DisplayName("Topology Gradient Magnitude Threshold Factor")]
        [Tooltip("")]
        public float TopologyGradientMagnitudeThresholdFactor { get; init; }

        [DisplayName("Topology Intensity Threshold Factor")]
        [Tooltip("")]
        public float TopologyIntensityThresholdFactor { get; init; }

        [DisplayName("Topology Merge Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyMergeDistanceThresholdFactor { get; init; }

        [DisplayName("Topology Min Distance Threshold Factor")]
        [Tooltip("")]
        public float TopologyMinDistanceThresholdFactor { get; init; }

        [DisplayName("Topology Max Positional Offset")]
        [Tooltip("")]
        public float TopologyMaxPositionalOffset { get; init; }



        public DarkMatterNodeGenerationSettings()
        {
            
            this.CountAgeFactor = ConfigConstants.DarkMatterNode.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterNode.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterNode.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterNode.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterNode.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterNode.CountDarkEnergyPercentFactor;
            this.TopologyDensityThresholdFactor = ConfigConstants.DarkMatterNode.TopologyDensityThresholdFactor;
            this.TopologyGradientMagnitudeThresholdFactor = ConfigConstants.DarkMatterNode.TopologyGradientMagnitudeThresholdFactor;
            this.TopologyIntensityThresholdFactor = ConfigConstants.DarkMatterNode.TopologyIntensityThresholdFactor;
            this.TopologyMergeDistanceThresholdFactor = ConfigConstants.DarkMatterNode.TopologyMergeDistanceThresholdFactor;
            this.TopologyMinDistanceThresholdFactor = ConfigConstants.DarkMatterNode.TopologyMinDistanceThresholdFactor;
            this.TopologyMaxPositionalOffset = ConfigConstants.DarkMatterNode.TopologyMaxPositionalOffset;
        }
    }
}
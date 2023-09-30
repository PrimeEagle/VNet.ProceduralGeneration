﻿namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    internal static class ConfigConstants
    {
        internal static float DimensionX { get; } = 100f;
        internal static float DimensionY { get; } = 100f;
        internal static float DimensionZ { get; } = 100f;
        internal static double DefaultMinDarkEnergyPercent { get; } = 65.0;
        internal static double DefaultMaxDarkEnergyPercent { get; } = 75.0;
        internal static double DefaultMinDarkMatterPercent { get; } = 20.0;
        internal static double DefaultMaxDarkMatterPercent { get; } = 30.0;
        internal static double DefaultMinBaryonicMatterPercent { get; } = 4.0;
        internal static double DefaultMaxBaryonicMatterPercent { get; } = 6.0;
        internal static float DefaultMinUniverseAge { get; } = 5e9f;                                    // years
        internal static float DefaultMaxUniverseAge { get; } = 20e9f;                                   // years
        internal static double DefaultBaselineExpansionRate { get; } = 70.0;                            // km/s/Mpc
        internal static double DefaultBaselineCosmicMicrowaveBackground { get; } = 2.735;               // Kelvin
        internal static int BaryonicMatterNodeBaseCount { get; } = 300;
        internal static double BaryonicMatterNodeAgeFactor { get; } = 5.0;
        internal static double BaryonicMatterNodeMassFactor { get; } = 1 / 1e30;
        internal static double BaryonicMatterNodeSizeFactor { get; } = 1 / 1e9;
        internal static double BaryonicMatterNodeBaryonicMatterPercentFactor { get; } = 100;
        internal static double BaryonicMatterNodeDarkMatterPercentFactor { get; } = 200;
        internal static double BaryonicMatterNodeDarkEnergyPercentFactor { get; } = 100;
        internal static int BaryonicMatterFilamentBaseCount { get; } = 1000;
        internal static double BaryonicMatterFilamentAgeFactor { get; } = 10.0;
        internal static double BaryonicMatterFilamentMassFactor { get; } = 1 / 1e30;
        internal static double BaryonicMatterFilamentSizeFactor { get; } = 1 / 1e9;
        internal static double BaryonicMatterFilamentBaryonicMatterPercentFactor { get; } = 100;
        internal static double BaryonicMatterFilamentDarkMatterPercentFactor { get; } = 150;
        internal static double BaryonicMatterFilamentDarkEnergyPercentFactor { get; } = 100;
        internal static int BaryonicMatterSheetBaseCount { get; } = 300;
        internal static double BaryonicMatterSheetAgeFactor { get; } = 5.0;
        internal static double BaryonicMatterSheetMassFactor { get; } = 1 / 1e30;
        internal static double BaryonicMatterSheetSizeFactor { get; } = 1 / 1e9;
        internal static double BaryonicMatterSheetBaryonicMatterPercentFactor { get; } = 100;
        internal static double BaryonicMatterSheetDarkMatterPercentFactor { get; } = 150;
        internal static double BaryonicMatterSheetDarkEnergyPercentFactor { get; } = 100;
        internal static int BaryonicMatterVoidBaseCount { get; } = 1500;
        internal static double BaryonicMatterVoidAgeFactor { get; } = 8.0;
        internal static double BaryonicMatterVoidMassFactor { get; } = 1 / 1e30;
        internal static double BaryonicMatterVoidSizeFactor { get; } = 1 / 1e9;
        internal static double BaryonicMatterVoidBaryonicMatterPercentFactor { get; } = 100;
        internal static double BaryonicMatterVoidDarkEnergyPercentFactor { get; } = 100;
        internal static int DarkMatterNodeBaseCount { get; } = 500;
        internal static double DarkMatterNodeAgeFactor { get; } = 6.0;
        internal static double DarkMatterNodeMassFactor { get; } = 1 / 1e30;
        internal static double DarkMatterNodeSizeFactor { get; } = 1 / 1e9;
        internal static double DarkMatterNodeBaryonicMatterPercentFactor { get; } = 200;
        internal static double DarkMatterNodeDarkMatterPercentFactor { get; } = 100;
        internal static double DarkMatterNodeDarkEnergyPercentFactor { get; } = 100;
        internal static int DarkMatterFilamentBaseCount { get; } = 1500;
        internal static double DarkMatterFilamentAgeFactor { get; } = 12.0;
        internal static double DarkMatterFilamentMassFactor { get; } = 1 / 1e30;
        internal static double DarkMatterFilamentSizeFactor { get; } = 1 / 1e9;
        internal static double DarkMatterFilamentBaryonicMatterPercentFactor { get; } = 200;
        internal static double DarkMatterFilamentDarkMatterPercentFactor { get; } = 100;
        internal static double DarkMatterFilamentDarkEnergyPercentFactor { get; } = 100;
        internal static int DarkMatterSheetBaseCount { get; } = 500;
        internal static double DarkMatterSheetAgeFactor { get; } = 7.0;
        internal static double DarkMatterSheetMassFactor { get; } = 1 / 1e30;
        internal static double DarkMatterSheetSizeFactor { get; } = 1 / 1e9;
        internal static double DarkMatterSheetBaryonicMatterPercentFactor { get; } = 200;
        internal static double DarkMatterSheetDarkMatterPercentFactor { get; } = 100;
        internal static double DarkMatterSheetDarkEnergyPercentFactor { get; } = 100;
        internal static int DarkMatterVoidBaseCount { get; } = 1400;
        internal static double DarkMatterVoidAgeFactor { get; } = 7.0;
        internal static double DarkMatterVoidMassFactor { get; } = 1 / 1e30;
        internal static double DarkMatterVoidSizeFactor { get; } = 1 / 1e9;
        internal static double DarkMatterVoidDarkMatterPercentFactor { get; } = 100;
        internal static double DarkMatterVoidDarkEnergyPercentFactor { get; } = 150;
        internal static float TopologyBaryonicMatterNodeDensityThresholdFactor { get; } = 1.2f;
        internal static float TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor { get; } = 0.2f;
        internal static float TopologyBaryonicMatterNodeIntensityThresholdFactor { get; } = 1.2f;
        internal static float TopologyBaryonicMatterNodeMergeDistanceThresholdFactor { get; } = 0.2f;
        internal static float TopologyBaryonicMatterNodeMinDistanceThresholdFactor { get; } = 1.2f;
        internal static float TopologyBaryonicMatterNodeMaxPositionalOffset { get; } = 0.2f;
        internal static float TopologyDarkMatterNodeDensityThresholdFactor { get; } = 1.2f;
        internal static float TopologyDarkMatterNodeGradientMagnitudeThresholdFactor { get; } = 0.2f;
        internal static float TopologyDarkMatterNodeIntensityThresholdFactor { get; } = 1.2f;
        internal static float TopologyDarkMatterNodeMergeDistanceThresholdFactor { get; } = 0.2f;
        internal static float TopologyDarkMatterNodeMinDistanceThresholdFactor { get; } = 1.2f;
        internal static float TopologyDarkMatterNodeMaxPositionalOffset { get; } = 0.2f;
    }
}
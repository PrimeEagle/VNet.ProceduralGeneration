using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AdvancedGenerationSettings : ISettings
    {
        public IRandomGenerationAlgorithm RandomGenerator { get; set; }
        public double MinConnectivityFactor { get; set; }
        public double MaxConnectivityFactor { get; set; }
        public float GaussianSigma { get; set; }
        public double BaselineExpansionRate { get; set; }
        public double BaselineCosmicMicrowaveBackground { get; set; }
        public double BaryonicMatterNodeAgeFactor { get; set; }
        public double BaryonicMatterNodeMassFactor { get; set; }
        public double BaryonicMatterNodeSizeFactor { get; set; }
        public double BaryonicMatterNodeBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterNodeDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterNodeDarkEnergyPercentFactor { get; set; }
        public double BaryonicMatterFilamentAgeFactor { get; set; }
        public double BaryonicMatterFilamentMassFactor { get; set; }
        public double BaryonicMatterFilamentSizeFactor { get; set; }
        public double BaryonicMatterFilamentBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterFilamentDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterFilamentDarkEnergyPercentFactor { get; set; }
        public double BaryonicMatterSheetAgeFactor { get; set; }
        public double BaryonicMatterSheetMassFactor { get; set; }
        public double BaryonicMatterSheetSizeFactor { get; set; }
        public double BaryonicMatterSheetBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterSheetDarkMatterPercentFactor { get; set; }
        public double BaryonicMatterSheetDarkEnergyPercentFactor { get; set; }
        public double BaryonicMatterVoidAgeFactor { get; set; }
        public double BaryonicMatterVoidMassFactor { get; set; }
        public double BaryonicMatterVoidSizeFactor { get; set; }
        public double BaryonicMatterVoidBaryonicMatterPercentFactor { get; set; }
        public double BaryonicMatterVoidDarkEnergyPercentFactor { get; set; }
        public double DarkMatterNodeAgeFactor { get; set; }
        public double DarkMatterNodeMassFactor { get; set; }
        public double DarkMatterNodeSizeFactor { get; set; }
        public double DarkMatterNodeBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterNodeDarkMatterPercentFactor { get; set; }
        public double DarkMatterNodeDarkEnergyPercentFactor { get; set; }
        public double DarkMatterFilamentAgeFactor { get; set; }
        public double DarkMatterFilamentMassFactor { get; set; }
        public double DarkMatterFilamentSizeFactor { get; set; }
        public double DarkMatterFilamentBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterFilamentDarkMatterPercentFactor { get; set; }
        public double DarkMatterFilamentDarkEnergyPercentFactor { get; set; }
        public double DarkMatterSheetAgeFactor { get; set; }
        public double DarkMatterSheetMassFactor { get; set; }
        public double DarkMatterSheetSizeFactor { get; set; }
        public double DarkMatterSheetBaryonicMatterPercentFactor { get; set; }
        public double DarkMatterSheetDarkMatterPercentFactor { get; set; }
        public double DarkMatterSheetDarkEnergyPercentFactor { get; set; }
        public double DarkMatterVoidAgeFactor { get; set; }
        public double DarkMatterVoidMassFactor { get; set; }
        public double DarkMatterVoidSizeFactor { get; set; }
        public double DarkMatterVoidDarkMatterPercentFactor { get; set; }
        public double DarkMatterVoidDarkEnergyPercentFactor { get; set; }
        public float TopologyBaryonicMatterNodeDensityThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeIntensityThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor { get; set; }
        public float TopologyBaryonicMatterNodeMaxPositionalOffset { get; set; }
        public float TopologyDarkMatterNodeDensityThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeGradientMagnitudeThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeIntensityThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeSeedMinDistanceThresholdFactor { get; set; }
        public float TopologyDarkMatterNodeMaxPositionalOffset { get; set; }



        public AdvancedGenerationSettings()
        {
            this.RandomGenerator = new DotNetGenerator();
            this.MinConnectivityFactor = ConfigConstants.DefaultMinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.DefaultMaxConnectivityFactor;
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
            this.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeSeedMergeDistanceThresholdFactor;
            this.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor = ConfigConstants.TopologyBaryonicMatterNodeSeedMinDistanceThresholdFactor;
            this.TopologyBaryonicMatterNodeMaxPositionalOffset = ConfigConstants.TopologyBaryonicMatterNodeMaxPositionalOffset;
            this.TopologyDarkMatterNodeDensityThresholdFactor = ConfigConstants.TopologyDarkMatterNodeDensityThresholdFactor;
            this.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor = ConfigConstants.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor;
            this.TopologyDarkMatterNodeIntensityThresholdFactor = ConfigConstants.TopologyDarkMatterNodeIntensityThresholdFactor;
            this.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor = ConfigConstants.TopologyDarkMatterNodeSeedMergeDistanceThresholdFactor;
            this.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor = ConfigConstants.TopologyDarkMatterNodeSeedMinDistanceThresholdFactor;
            this.TopologyDarkMatterNodeMaxPositionalOffset = ConfigConstants.TopologyDarkMatterNodeMaxPositionalOffset;
        }
    }
}